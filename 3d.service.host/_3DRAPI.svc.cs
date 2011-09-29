//  Copyright 2011 U.S. Department of Defense

//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at

//      http://www.apache.org/licenses/LICENSE-2.0

//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Web;
using System.IO;
using System.Configuration;

namespace vwar.service.host
{
    /// <summary>
    /// 
    /// </summary>
    public class _3DRAPI : _3DRAPI_Http_Imp, I3DRAPI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="terms"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<SearchResult> Search2(string terms, string key) { return Search(terms, key); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Review> GetReviews2(string pid, string key) { return GetReviews(pid, key); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Metadata GetMetadata2(string pid, string key) { return GetMetadata(pid, key); }

    }
}
