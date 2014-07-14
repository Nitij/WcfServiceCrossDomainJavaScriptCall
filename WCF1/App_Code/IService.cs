using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;

namespace Microsoft.ServiceModel.Samples
{
    [ServiceContract(Namespace = "")]
    
    public interface ICalculator
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        [WebInvoke(
        Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        Double Add(Double n1, Double n2);

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(
        Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Double Subtract(Double n1, Double n2);

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(
        Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Double Divide(Double n1, Double n2);

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(
        Method = "*",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Double Multiply(Double n1, Double n2);
    }
}





