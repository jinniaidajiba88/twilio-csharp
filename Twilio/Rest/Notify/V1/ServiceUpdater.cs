using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Notify.V1 
{

    public class ServiceUpdater : Updater<ServiceResource> 
    {
        public string sid { get; }
        public string friendlyName { get; set; }
        public string apnCredentialSid { get; set; }
        public string gcmCredentialSid { get; set; }
        public string messagingServiceSid { get; set; }
        public string facebookMessengerPageId { get; set; }
        public string defaultApnNotificationProtocolVersion { get; set; }
        public string defaultGcmNotificationProtocolVersion { get; set; }
    
        /// <summary>
        /// Construct a new ServiceUpdater
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="apnCredentialSid"> The apn_credential_sid </param>
        /// <param name="gcmCredentialSid"> The gcm_credential_sid </param>
        /// <param name="messagingServiceSid"> The messaging_service_sid </param>
        /// <param name="facebookMessengerPageId"> The facebook_messenger_page_id </param>
        /// <param name="defaultApnNotificationProtocolVersion"> The default_apn_notification_protocol_version </param>
        /// <param name="defaultGcmNotificationProtocolVersion"> The default_gcm_notification_protocol_version </param>
        public ServiceUpdater(string sid, string friendlyName=null, string apnCredentialSid=null, string gcmCredentialSid=null, string messagingServiceSid=null, string facebookMessengerPageId=null, string defaultApnNotificationProtocolVersion=null, string defaultGcmNotificationProtocolVersion=null)
        {
            this.facebookMessengerPageId = facebookMessengerPageId;
            this.sid = sid;
            this.gcmCredentialSid = gcmCredentialSid;
            this.defaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion;
            this.apnCredentialSid = apnCredentialSid;
            this.defaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion;
            this.friendlyName = friendlyName;
            this.messagingServiceSid = messagingServiceSid;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated ServiceResource </returns> 
        public override async Task<ServiceResource> UpdateAsync(ITwilioRestClient client)
        {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.NOTIFY,
                "/v1/Services/" + this.sid + ""
            );
            AddPostParams(request);
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("ServiceResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ServiceResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated ServiceResource </returns> 
        public override ServiceResource Update(ITwilioRestClient client)
        {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.NOTIFY,
                "/v1/Services/" + this.sid + ""
            );
            AddPostParams(request);
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("ServiceResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ServiceResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void AddPostParams(Request request)
        {
            if (friendlyName != null)
            {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (apnCredentialSid != null)
            {
                request.AddPostParam("ApnCredentialSid", apnCredentialSid);
            }
            
            if (gcmCredentialSid != null)
            {
                request.AddPostParam("GcmCredentialSid", gcmCredentialSid);
            }
            
            if (messagingServiceSid != null)
            {
                request.AddPostParam("MessagingServiceSid", messagingServiceSid);
            }
            
            if (facebookMessengerPageId != null)
            {
                request.AddPostParam("FacebookMessengerPageId", facebookMessengerPageId);
            }
            
            if (defaultApnNotificationProtocolVersion != null)
            {
                request.AddPostParam("DefaultApnNotificationProtocolVersion", defaultApnNotificationProtocolVersion);
            }
            
            if (defaultGcmNotificationProtocolVersion != null)
            {
                request.AddPostParam("DefaultGcmNotificationProtocolVersion", defaultGcmNotificationProtocolVersion);
            }
        }
    }
}