/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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




namespace Twilio.Rest.Preview.DeployedDevices.Fleet
{

    /// <summary> Create a new Key credential in the Fleet, optionally giving it a friendly name and assigning to a Device. </summary>
    public class CreateKeyOptions : IOptions<KeyResource>
    {
        
        
        public string PathFleetSid { get; }

        ///<summary> Provides a human readable descriptive text for this Key credential, up to 256 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Provides the unique string identifier of an existing Device to become authenticated with this Key credential. </summary> 
        public string DeviceSid { get; set; }


        /// <summary> Construct a new CreateDeployedDevicesKeyOptions </summary>
        /// <param name="pathFleetSid">  </param>
        public CreateKeyOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (DeviceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeviceSid", DeviceSid));
            }
            return p;
        }

        

    }
    /// <summary> Delete a specific Key credential from the Fleet, effectively disallowing any inbound client connections that are presenting it. </summary>
    public class DeleteKeyOptions : IOptions<KeyResource>
    {
        
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Key credential resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteDeployedDevicesKeyOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Key credential resource. </param>
        public DeleteKeyOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Fetch information about a specific Key credential in the Fleet. </summary>
    public class FetchKeyOptions : IOptions<KeyResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Key credential resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchDeployedDevicesKeyOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Key credential resource. </param>
        public FetchKeyOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of all Keys credentials belonging to the Fleet. </summary>
    public class ReadKeyOptions : ReadOptions<KeyResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Filters the resulting list of Keys by a unique string identifier of an authenticated Device. </summary> 
        public string DeviceSid { get; set; }



        /// <summary> Construct a new ListDeployedDevicesKeyOptions </summary>
        /// <param name="pathFleetSid">  </param>
        public ReadKeyOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DeviceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeviceSid", DeviceSid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

    /// <summary> Update the given properties of a specific Key credential in the Fleet, giving it a friendly name or assigning to a Device. </summary>
    public class UpdateKeyOptions : IOptions<KeyResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Key credential resource. </summary> 
        public string PathSid { get; }

        ///<summary> Provides a human readable descriptive text for this Key credential, up to 256 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Provides the unique string identifier of an existing Device to become authenticated with this Key credential. </summary> 
        public string DeviceSid { get; set; }



        /// <summary> Construct a new UpdateDeployedDevicesKeyOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Key credential resource. </param>
        public UpdateKeyOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (DeviceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeviceSid", DeviceSid));
            }
            return p;
        }

        

    }


}

