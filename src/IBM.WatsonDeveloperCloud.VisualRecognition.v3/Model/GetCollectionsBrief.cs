/**
* Copyright 2017 IBM Corp. All Rights Reserved.
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
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;
namespace IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model
{
    /// <summary>
    /// success
    /// </summary>
    public class GetCollectionsBrief
    {
        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }
        /// <summary>
        /// Gets or Sets ImageFile
        /// </summary>
        [JsonProperty("image_file")]
        public string ImageFile { get; set; }
        /// <summary>
        /// Metadat JSON object (key value pairs)
        /// </summary>
        /// <value>Metadata JSON object (key value pairs)</value>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }
}
