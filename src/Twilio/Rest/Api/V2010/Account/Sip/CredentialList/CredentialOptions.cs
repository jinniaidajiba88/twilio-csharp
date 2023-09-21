/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account.Sip.CredentialList
{

    /// <summary> Create a new credential resource. </summary>
    public class CreateCredentialOptions : IOptions<CredentialResource>
    {
        
        ///<summary> The unique id that identifies the credential list to include the created credential. </summary> 
        public string PathCredentialListSid { get; }

        ///<summary> The username that will be passed when authenticating SIP requests. The username should be sent in response to Twilio's challenge of the initial INVITE. It can be up to 32 characters long. </summary> 
        public string Username { get; }

        ///<summary> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </summary> 
        public string Password { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }


        /// <summary> Construct a new CreateSipCredentialOptions </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list to include the created credential. </param>
        /// <param name="username"> The username that will be passed when authenticating SIP requests. The username should be sent in response to Twilio's challenge of the initial INVITE. It can be up to 32 characters long. </param>
        /// <param name="password"> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </param>
        public CreateCredentialOptions(string pathCredentialListSid, string username, string password)
        {
            PathCredentialListSid = pathCredentialListSid;
            Username = username;
            Password = password;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Username != null)
            {
                p.Add(new KeyValuePair<string, string>("Username", Username));
            }
            if (Password != null)
            {
                p.Add(new KeyValuePair<string, string>("Password", Password));
            }
            return p;
        }

        

    }
    /// <summary> Delete a credential resource. </summary>
    public class DeleteCredentialOptions : IOptions<CredentialResource>
    {
        
        ///<summary> The unique id that identifies the credential list that contains the desired credentials. </summary> 
        public string PathCredentialListSid { get; }

        ///<summary> The unique id that identifies the resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipCredentialOptions </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to delete. </param>
        public DeleteCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Fetch a single credential. </summary>
    public class FetchCredentialOptions : IOptions<CredentialResource>
    {
    
        ///<summary> The unique id that identifies the credential list that contains the desired credential. </summary> 
        public string PathCredentialListSid { get; }

        ///<summary> The unique id that identifies the resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipCredentialOptions </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to fetch. </param>
        public FetchCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of credentials. </summary>
    public class ReadCredentialOptions : ReadOptions<CredentialResource>
    {
    
        ///<summary> The unique id that identifies the credential list that contains the desired credentials. </summary> 
        public string PathCredentialListSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListSipCredentialOptions </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        public ReadCredentialOptions(string pathCredentialListSid)
        {
            PathCredentialListSid = pathCredentialListSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

    /// <summary> Update a credential resource. </summary>
    public class UpdateCredentialOptions : IOptions<CredentialResource>
    {
    
        ///<summary> The unique id that identifies the credential list that includes this credential. </summary> 
        public string PathCredentialListSid { get; }

        ///<summary> The unique id that identifies the resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </summary> 
        public string Password { get; set; }



        /// <summary> Construct a new UpdateSipCredentialOptions </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that includes this credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to update. </param>
        public UpdateCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Password != null)
            {
                p.Add(new KeyValuePair<string, string>("Password", Password));
            }
            return p;
        }

        

    }


}

