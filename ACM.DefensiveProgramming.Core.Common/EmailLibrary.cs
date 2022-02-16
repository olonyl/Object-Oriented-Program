using System;

namespace ACM.DefensiveProgramming.Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string emailAddress, string v)
        {
            /*
               If a valid email address is provided
            Send an email
             */
            try
            {
                //Send an email.
            }
            catch (InvalidOperationException ex)
            {
                // log the issue
                throw;
            }
        }
    }
}
