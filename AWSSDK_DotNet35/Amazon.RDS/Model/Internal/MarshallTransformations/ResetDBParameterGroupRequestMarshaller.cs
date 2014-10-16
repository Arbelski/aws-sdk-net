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
    /// ResetDBParameterGroup Request Marshaller
    /// </summary>       
    public class ResetDBParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetDBParameterGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ResetDBParameterGroupRequest)input);
        }
    
        public IRequest Marshall(ResetDBParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ResetDBParameterGroup");
            request.Parameters.Add("Version", "2014-09-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBParameterGroupName())
                {
                    request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
                }
                if(publicRequest.IsSetParameters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Parameters)
                    {
                        if(publicRequestlistValue.IsSetAllowedValues())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AllowedValues", StringUtils.FromString(publicRequestlistValue.AllowedValues));
                        }
                        if(publicRequestlistValue.IsSetApplyMethod())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ApplyMethod", StringUtils.FromString(publicRequestlistValue.ApplyMethod));
                        }
                        if(publicRequestlistValue.IsSetApplyType())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ApplyType", StringUtils.FromString(publicRequestlistValue.ApplyType));
                        }
                        if(publicRequestlistValue.IsSetDataType())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DataType", StringUtils.FromString(publicRequestlistValue.DataType));
                        }
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
                        if(publicRequestlistValue.IsSetIsModifiable())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IsModifiable", StringUtils.FromBool(publicRequestlistValue.IsModifiable));
                        }
                        if(publicRequestlistValue.IsSetMinimumEngineVersion())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MinimumEngineVersion", StringUtils.FromString(publicRequestlistValue.MinimumEngineVersion));
                        }
                        if(publicRequestlistValue.IsSetParameterName())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterName", StringUtils.FromString(publicRequestlistValue.ParameterName));
                        }
                        if(publicRequestlistValue.IsSetParameterValue())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                        }
                        if(publicRequestlistValue.IsSetSource())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Source", StringUtils.FromString(publicRequestlistValue.Source));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetResetAllParameters())
                {
                    request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(publicRequest.ResetAllParameters));
                }
            }
            return request;
        }
    }
}