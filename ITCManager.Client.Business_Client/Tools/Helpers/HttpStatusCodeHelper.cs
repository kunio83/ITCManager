using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools.Helpers
{
    public static class HttpStatusCodeHelper
    {

        public static Boolean IsHttpStatusCodeExpected(System.Net.HttpStatusCode Value, System.Net.HttpStatusCode Expected)
        {
            var correct = false;

            if (Value == Expected)
            {
                correct = true;
            }
            else
            {
                var error = GetException(Value);
                if (error != null)
                    throw error;
            }

            return correct;
        }

        internal static Exception GetException(System.Net.HttpStatusCode statusCode)
        {
            Exception exception = null;

            switch (statusCode)
            {
                /*case System.Net.HttpStatusCode.BadGateway:
                    break;
                case System.Net.HttpStatusCode.BadRequest:
                    break;
                case System.Net.HttpStatusCode.Forbidden:
                    break;
                case System.Net.HttpStatusCode.GatewayTimeout:
                    break;
                case System.Net.HttpStatusCode.InternalServerError:
                    break;*/
                case System.Net.HttpStatusCode.PaymentRequired:
                    {
                        exception = new Exception();
                        break;
                    }
            }

            return exception;
        }
    }
}
