/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.com.blockchain.exchange.rest.model
{
    /// <summary>
    /// CreateWithdrawalRequest
    /// </summary>
    [DataContract]
    public partial class CreateWithdrawalRequest :  IEquatable<CreateWithdrawalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWithdrawalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWithdrawalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWithdrawalRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount to withdraw in the currency specified.</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="beneficiary">beneficiary (required).</param>
        /// <param name="sendMax">If set, sends the full available amount, minus fees. Amount may not be specified in that case. .</param>
        public CreateWithdrawalRequest(double amount = default(double), string currency = default(string), string beneficiary = default(string), bool sendMax = default(bool))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for CreateWithdrawalRequest and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "beneficiary" is required (not null)
            if (beneficiary == null)
            {
                throw new InvalidDataException("beneficiary is a required property for CreateWithdrawalRequest and cannot be null");
            }
            else
            {
                this.Beneficiary = beneficiary;
            }
            
            this.Amount = amount;
            this.SendMax = sendMax;
        }
        
        /// <summary>
        /// The amount to withdraw in the currency specified
        /// </summary>
        /// <value>The amount to withdraw in the currency specified</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Beneficiary
        /// </summary>
        [DataMember(Name="beneficiary", EmitDefaultValue=true)]
        public string Beneficiary { get; set; }

        /// <summary>
        /// If set, sends the full available amount, minus fees. Amount may not be specified in that case. 
        /// </summary>
        /// <value>If set, sends the full available amount, minus fees. Amount may not be specified in that case. </value>
        [DataMember(Name="sendMax", EmitDefaultValue=false)]
        public bool SendMax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWithdrawalRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Beneficiary: ").Append(Beneficiary).Append("\n");
            sb.Append("  SendMax: ").Append(SendMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWithdrawalRequest);
        }

        /// <summary>
        /// Returns true if CreateWithdrawalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWithdrawalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWithdrawalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Beneficiary == input.Beneficiary ||
                    (this.Beneficiary != null &&
                    this.Beneficiary.Equals(input.Beneficiary))
                ) && 
                (
                    this.SendMax == input.SendMax ||
                    (this.SendMax != null &&
                    this.SendMax.Equals(input.SendMax))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Beneficiary != null)
                    hashCode = hashCode * 59 + this.Beneficiary.GetHashCode();
                if (this.SendMax != null)
                    hashCode = hashCode * 59 + this.SendMax.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            
            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"^[A-Z]{3,5}$", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            yield break;
        }
    }

}
