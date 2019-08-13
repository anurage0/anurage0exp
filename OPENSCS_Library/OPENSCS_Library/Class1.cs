using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;
using System;
using System.Collections.Generic;
using UnifiedAutomation.UaBase;
using UnifiedAutomation.UaClient;

namespace OPENSCS_Library
{
    public class OPENSCS_Library
    {
        ApplicationInstance AppInstance = ApplicationInstance.Default;
        Session AppSession = new Session();


        public void Connect(string endpointUrl)
        {
            AppSession.UserIdentity = new UserIdentity();
            AppSession.SessionName = "urn:ACGIDT053:UnifiedAutomation:UaExpert";
            //AppSession.Application.CertificateGroups[0];            
            //string endpointUrl = "opc.tcp://212.43.72.27:51510/UA/WipotecServer/";
            AppSession.Connect(endpointUrl, SecuritySelection.None);
            ICertificate certificateServer = SecurityUtils.LoadCertificate(AppSession.EndpointDescription.ServerCertificate);
            AppSession.Application.TrustedStore.Add(certificateServer, true);

            /// [Step 1]
            // parse the object id.
            NodeId objectId = NodeId.Parse("ns=2;i=15108");

            // get the selected method id.            
            NodeId methodId = NodeId.Parse("ns=2;i=15057");

            // get input arguments.
            UInt32 a = 2;
            List<Variant> inputArguments = new List<Variant>
            {
                new Variant(string.Empty, TypeInfo.Scalars.String), new Variant(a,TypeInfo.Scalars.UInt32), new Variant(string.Empty, TypeInfo.Scalars.String),
                new Variant(null, TypeInfo.Arrays.ExtensionObject), new Variant(string.Empty, TypeInfo.Scalars.String)
            };

            /// [Step 2]
            List<StatusCode> inputArgumentErrors;
            List<Variant> outputArguments = null;

            // call the method on the server.
            StatusCode error = AppSession.Call(
                objectId,
                methodId,
                inputArguments,
                out inputArgumentErrors,
                out outputArguments);

            AppSession.Disconnect();

        }

        //public void ConnectAndCall(string endpoint)
        //{
        //    UAEndpointDescriptor endpointDescriptor =
        //        "opc.tcp://212.43.72.27:51510/UA/WipotecServer";
        //    // or "http://opcua.demo-this.com:51211/UA/SampleServer" (not in .NET Standard)
        //    // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

        //    object[] inputs =
        //    {
        //        string.Empty,
        //        1,
        //        string.Empty,
        //        null,
        //        string.Empty
        //    };

        //    TypeCode[] typeCodes =
        //    {
        //        TypeCode.Boolean,
        //        TypeCode.SByte,
        //        TypeCode.Byte,
        //        TypeCode.Int16,
        //        TypeCode.UInt16,
        //        TypeCode.Int32,
        //        TypeCode.UInt32,
        //        TypeCode.Int64,
        //        TypeCode.UInt64,
        //        TypeCode.Single,
        //        TypeCode.Double
        //    };

        //    // Instantiate the client object
        //    var client = new EasyUAClient();

        //    // Perform the operation
        //    object[] outputs;
        //    try
        //    {
        //        outputs = client.CallMethod(
        //            endpointDescriptor,
        //            "ns=2;i=15108",
        //            "ns=2;i=15057",
        //            inputs,
        //            typeCodes);
        //    }
        //    catch (UAException uaException)
        //    {
        //        Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message);
        //        return;
        //    }

        //    // Display results
        //    for (int i = 0; i < outputs.Length; i++)
        //        Console.WriteLine("outputs[{0}]: {1}", i, outputs[i]);

        //    // Example output:
        //    //outputs[0]: False
        //    //outputs[1]: 1
        //    //outputs[2]: 2
        //    //outputs[3]: 3
        //    //outputs[4]: 4
        //    //outputs[5]: 5
        //    //outputs[6]: 6
        //    //outputs[7]: 7
        //    //outputs[8]: 8
        //    //outputs[9]: 9
        //    //outputs[10]: 10        
        //}
    }
}
