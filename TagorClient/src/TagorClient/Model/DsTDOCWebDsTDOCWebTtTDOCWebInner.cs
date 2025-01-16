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
    /// DsTDOCWebDsTDOCWebTtTDOCWebInner
    /// </summary>
    [DataContract(Name = "dsTDOCWeb_dsTDOCWeb_ttTDOCWeb_inner")]
    public partial class DsTDOCWebDsTDOCWebTtTDOCWebInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsTDOCWebDsTDOCWebTtTDOCWebInner" /> class.
        /// </summary>
        /// <param name="datumDocument">datumDocument.</param>
        /// <param name="dISFLMNExtensie">dISFLMNExtensie.</param>
        /// <param name="dISid">dISid.</param>
        /// <param name="naam">naam.</param>
        /// <param name="tDOCId">tDOCId.</param>
        /// <param name="tQDISGROEPId">tQDISGROEPId.</param>
        /// <param name="inhoud">inhoud.</param>
        public DsTDOCWebDsTDOCWebTtTDOCWebInner(DateOnly datumDocument = default(DateOnly), string dISFLMNExtensie = default(string), int dISid = default(int), string naam = default(string), string tDOCId = default(string), string tQDISGROEPId = default(string), string inhoud = default(string))
        {
            this.DatumDocument = datumDocument;
            this.DISFLMNExtensie = dISFLMNExtensie;
            this.DISid = dISid;
            this.Naam = naam;
            this.TDOCId = tDOCId;
            this.TQDISGROEPId = tQDISGROEPId;
            this.Inhoud = inhoud;
        }

        /// <summary>
        /// Gets or Sets DatumDocument
        /// </summary>
        [DataMember(Name = "DatumDocument", EmitDefaultValue = false)]
        public DateOnly DatumDocument { get; set; }

        /// <summary>
        /// Gets or Sets DISFLMNExtensie
        /// </summary>
        [DataMember(Name = "DISFLMN_Extensie", EmitDefaultValue = false)]
        public string DISFLMNExtensie { get; set; }

        /// <summary>
        /// Gets or Sets DISid
        /// </summary>
        [DataMember(Name = "DISid", EmitDefaultValue = false)]
        public int DISid { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name = "Naam", EmitDefaultValue = false)]
        public string Naam { get; set; }

        /// <summary>
        /// Gets or Sets TDOCId
        /// </summary>
        [DataMember(Name = "TDOC_Id", EmitDefaultValue = false)]
        public string TDOCId { get; set; }

        /// <summary>
        /// Gets or Sets TQDISGROEPId
        /// </summary>
        [DataMember(Name = "TQDISGROEP_Id", EmitDefaultValue = false)]
        public string TQDISGROEPId { get; set; }

        /// <summary>
        /// Gets or Sets Inhoud
        /// </summary>
        [DataMember(Name = "Inhoud", EmitDefaultValue = false)]
        public string Inhoud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DsTDOCWebDsTDOCWebTtTDOCWebInner {\n");
            sb.Append("  DatumDocument: ").Append(DatumDocument).Append("\n");
            sb.Append("  DISFLMNExtensie: ").Append(DISFLMNExtensie).Append("\n");
            sb.Append("  DISid: ").Append(DISid).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  TDOCId: ").Append(TDOCId).Append("\n");
            sb.Append("  TQDISGROEPId: ").Append(TQDISGROEPId).Append("\n");
            sb.Append("  Inhoud: ").Append(Inhoud).Append("\n");
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