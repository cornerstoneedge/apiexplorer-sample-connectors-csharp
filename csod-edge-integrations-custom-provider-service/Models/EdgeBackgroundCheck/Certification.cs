/*
 * Edge.Integration.Host.BackgroundCheck
 *
 * Edge Custom Background Check API Template. Use this template to help generate your API contracts so that you can connect with CSOD and become a custom Background Check provider. Detailed in this API are endpoints that should be implemented so that the contract can adhere to Edge Custom Background Check Provier standards
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace csod_edge_integrations_custom_provider_service.Models.EdgeBackgroundCheck
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Certification :  IEquatable<Certification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certification" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="IssuedDate">IssuedDate.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="Description">Description.</param>
        public Certification(string Name = null, string Organization = null, string IssuedDate = null, string ExpirationDate = null, string Description = null)
        {
            this.Name = Name;
            this.Organization = Organization;
            this.IssuedDate = IssuedDate;
            this.ExpirationDate = ExpirationDate;
            this.Description = Description;
            
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets IssuedDate
        /// </summary>
        [DataMember(Name="issuedDate")]
        public string IssuedDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Certification {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  IssuedDate: ").Append(IssuedDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Certification)obj);
        }

        /// <summary>
        /// Returns true if Certification instances are equal
        /// </summary>
        /// <param name="other">Instance of Certification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Certification other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.IssuedDate == other.IssuedDate ||
                    this.IssuedDate != null &&
                    this.IssuedDate.Equals(other.IssuedDate)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.IssuedDate != null)
                    hash = hash * 59 + this.IssuedDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Certification left, Certification right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Certification left, Certification right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}