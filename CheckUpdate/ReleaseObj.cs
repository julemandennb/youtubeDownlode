using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUpdate
{
    public class ReleaseObj
    {

        public string Url;

        public string HtmlUrl;

        public string AssetsUrl;

        public string UploadUrl;

        public int Id;


        public string NodeId;

        public string TagName;

        public string TargetCommitish;

        public string Name;

        public string Body;

        public bool Draft;

        public bool Prerelease;

        public DateTimeOffset CreatedAt;

        public DateTimeOffset? PublishedAt;

        public string TarballUrl;

        public string ZipballUrl;


        public ReleaseObj()
        {

        }


    }
}
