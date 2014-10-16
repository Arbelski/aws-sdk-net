/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PurchaseReservedDBInstancesOffering Request Marshaller
    /// </summary>       
    public class PurchaseReservedDBInstancesOfferingRequestMarshaller : IMarshaller<IRequest, PurchaseReservedDBInstancesOfferingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PurchaseReservedDBInstancesOfferingRequest)input);
        }
    
        public IRequest Marshall(PurchaseReservedDBInstancesOfferingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "PurchaseReservedDBInstancesOffering");
            request.Parameters.Add("Version", "2014-09-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBInstanceCount())
                {
                    request.Parameters.Add("DBInstanceCount", StringUtils.FromInt(publicRequest.DBInstanceCount));
                }
                if(publicRequest.IsSetReservedDBInstanceId())
                {
                    request.Parameters.Add("ReservedDBInstanceId", StringUtils.FromString(publicRequest.ReservedDBInstanceId));
                }
                if(publicRequest.IsSetReservedDBInstancesOfferingId())
                {
                    request.Parameters.Add("ReservedDBInstancesOfferingId", StringUtils.FromString(publicRequest.ReservedDBInstancesOfferingId));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}