/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Amazon EC2 CSharp Library
 *  API Version: 2008-12-01
 *  Generated: Fri Dec 26 23:53:41 PST 2008 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace Amazon.EC2.Model
{
    [XmlTypeAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/")]
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/", IsNullable = false)]
    public class ConfirmProductInstanceRequest
    {
    
        private String productCodeField;

        private String instanceIdField;


        /// <summary>
        /// Gets and sets the ProductCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public String ProductCode
        {
            get { return this.productCodeField ; }
            set { this.productCodeField= value; }
        }



        /// <summary>
        /// Sets the ProductCode property
        /// </summary>
        /// <param name="productCode">ProductCode property</param>
        /// <returns>this instance</returns>
        public ConfirmProductInstanceRequest WithProductCode(String productCode)
        {
            this.productCodeField = productCode;
            return this;
        }



        /// <summary>
        /// Checks if ProductCode property is set
        /// </summary>
        /// <returns>true if ProductCode property is set</returns>
        public Boolean IsSetProductCode()
        {
            return  this.productCodeField != null;

        }


        /// <summary>
        /// Gets and sets the InstanceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public String InstanceId
        {
            get { return this.instanceIdField ; }
            set { this.instanceIdField= value; }
        }



        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">InstanceId property</param>
        /// <returns>this instance</returns>
        public ConfirmProductInstanceRequest WithInstanceId(String instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }



        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public Boolean IsSetInstanceId()
        {
            return  this.instanceIdField != null;

        }





    }

}