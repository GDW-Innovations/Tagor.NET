/*
 * Tagor API
 *
 * Release date: 29/09/2022  ## REQUIREMENTS This version __requires__ Tagor >= 2.00.0000B0. Use [`Config/Info`](#operation/ConfigInfo) to get the active API version.  ## CHANGELOG - New [`Dossier/CreateAgenda`](#operation/DossierCreateAgenda) endpoint. - New return values in GetAgenda 'TJOB_Id, TJOBM_Id, TUSER_Id, Manueel and IsGeblokkeerd' - In CreateLine you can now add if the line is fixed with 'IsFixed' - In CreateLine you can now add a subarray with the intrests  ## INFO - Using the download button at the top you can import this collection of endpoints in **Postman** - In general all TQ(...)_Id fields are default fields which you can translate with the [`Code/GetDescription`](#operation/CodeGetDescription) endpoint. If you need an id to post to one of the endpoints you can use the [`Code/GetList`](#operation/CodeGetList) endpoint to get all possible values or [`Code/GetDescription`](#operation/CodeGetDescription) to get a value by code. These id's will be marked as `code id` in the documentation. - We chose to return all ids as string because these are 64bit integers which are too big for javascript to handle. - All italic text below the endpoint description is meant for people with access to Tagor. - The user needs an email address configured in Tagor for the services to work properly. - Pass the `Accept` header with `application/json` as value to have the server return errors in json format. - Most endpoints can be batched/paged by passing a `BATCH-SIZE` and `BATCH-NUMBER` record in `dsWebContext`.  # AUTHENTICATION Pass your token via an `Authorization` header like this: `Authorization: {bearer_format} {token}`.  ex: `Authorization: TGR IcoQbVw7wE...PPUPda61ET` <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2.00.0000B1
 * Contact: info@organi.be
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TagorClient.Client.OpenAPIDateConverter;

namespace TagorClient.Model
{
    /// <summary>
    /// DsTDOSLIJNWebDsTDOSLIJNWebTtTDOSLIJNWebInnerTtTDOSLIJNINTRInner
    /// </summary>
    [DataContract(Name = "dsTDOSLIJNWeb_dsTDOSLIJNWeb_ttTDOSLIJNWeb_inner_ttTDOSLIJNINTR_inner")]
    public partial class DsTDOSLIJNWebDsTDOSLIJNWebTtTDOSLIJNWebInnerTtTDOSLIJNINTRInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsTDOSLIJNWebDsTDOSLIJNWebTtTDOSLIJNWebInnerTtTDOSLIJNINTRInner" /> class.
        /// </summary>
        /// <param name="tQINTRESTId">tQINTRESTId.</param>
        /// <param name="intresttoeslag">intresttoeslag.</param>
        /// <param name="datumBegin">datumBegin.</param>
        /// <param name="datumEind">datumEind.</param>
        /// <param name="bedrag">bedrag.</param>
        /// <param name="deelHoofdsom">deelHoofdsom.</param>
        public DsTDOSLIJNWebDsTDOSLIJNWebTtTDOSLIJNWebInnerTtTDOSLIJNINTRInner(string tQINTRESTId = default(string), decimal intresttoeslag = default(decimal), string datumBegin = default(string), string datumEind = default(string), decimal bedrag = default(decimal), decimal deelHoofdsom = default(decimal))
        {
            this.TQINTRESTId = tQINTRESTId;
            this.Intresttoeslag = intresttoeslag;
            this.DatumBegin = datumBegin;
            this.DatumEind = datumEind;
            this.Bedrag = bedrag;
            this.DeelHoofdsom = deelHoofdsom;
        }

        /// <summary>
        /// Gets or Sets TQINTRESTId
        /// </summary>
        [DataMember(Name = "TQINTREST_Id", EmitDefaultValue = false)]
        public string TQINTRESTId { get; set; }

        /// <summary>
        /// Gets or Sets Intresttoeslag
        /// </summary>
        [DataMember(Name = "Intresttoeslag", EmitDefaultValue = false)]
        public decimal Intresttoeslag { get; set; }

        /// <summary>
        /// Gets or Sets DatumBegin
        /// </summary>
        [DataMember(Name = "DatumBegin", EmitDefaultValue = false)]
        public string DatumBegin { get; set; }

        /// <summary>
        /// Gets or Sets DatumEind
        /// </summary>
        [DataMember(Name = "DatumEind", EmitDefaultValue = false)]
        public string DatumEind { get; set; }

        /// <summary>
        /// Gets or Sets Bedrag
        /// </summary>
        [DataMember(Name = "Bedrag", EmitDefaultValue = false)]
        public decimal Bedrag { get; set; }

        /// <summary>
        /// Gets or Sets DeelHoofdsom
        /// </summary>
        [DataMember(Name = "DeelHoofdsom", EmitDefaultValue = false)]
        public decimal DeelHoofdsom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DsTDOSLIJNWebDsTDOSLIJNWebTtTDOSLIJNWebInnerTtTDOSLIJNINTRInner {\n");
            sb.Append("  TQINTRESTId: ").Append(TQINTRESTId).Append("\n");
            sb.Append("  Intresttoeslag: ").Append(Intresttoeslag).Append("\n");
            sb.Append("  DatumBegin: ").Append(DatumBegin).Append("\n");
            sb.Append("  DatumEind: ").Append(DatumEind).Append("\n");
            sb.Append("  Bedrag: ").Append(Bedrag).Append("\n");
            sb.Append("  DeelHoofdsom: ").Append(DeelHoofdsom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}