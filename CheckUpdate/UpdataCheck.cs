using Newtonsoft.Json;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUpdate
{
    public class UpdataCheck
    {
        private GitHubClient client;

        private string owner;

        private string repositoryName;

        public UpdataCheck(string name, string owner, string repositoryName)
        {
            client = new GitHubClient(new ProductHeaderValue(name));

            this.owner = owner;
            this.repositoryName = repositoryName;  
        }

        private async Task<IReadOnlyList<Release>> GetReleases()
        {
            var releases = await this.client.Repository.Release.GetAll(this.owner, this.repositoryName);

            return releases;
        }

        public async Task<ReleaseObj> lastReleases()
        {

            IReadOnlyList<Release> releases = await GetReleases();
            var latest = releases[0];


            //var fff = JsonConvert.SerializeObject(latest);

            ReleaseObj releasesobj = JsonConvert.DeserializeObject<ReleaseObj>(JsonConvert.SerializeObject(latest));

            return releasesobj;
        }

        public async Task<Release> FristReleases(string owner, string repositoryName)
        {

            IReadOnlyList<Release> releases = await GetReleases();
            var latest = releases[releases.Count - 1];
            return latest;
        }
    }
}
