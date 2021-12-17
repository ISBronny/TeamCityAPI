using System;
//using System = global::System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using TeamCityAPI.Query;

namespace TeamCityAPI
{
    public partial class TeamCityClient
    {
        public TeamCityClient(string baseUrl)
        {
            BaseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue { NoCache = true };
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
        }

        public void UseLoginAndPass(string user, string password)
        {
            var credentials = Encoding.ASCII.GetBytes($"{user}:{password}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

        }
        
        public void UseToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        
        //ToDo:
        //Uncomment
        public ITcQuery<Agents> Agents => new TcQuery<Agents>(this, GetAllAgentsAsync);
        //public TcQuery<Branches> Branches => new(this, GetAllBranchesAsync);
        public ITcQuery<Builds> Builds => new TcQuery<Builds>(this, GetAllBuildsAsync);
        public ITcQuery<Changes> Changes => new TcQuery<Changes>(this, GetAllChangesAsync);
        //public TcQuery<Groups> Groups => new(this, GetAllGroupsAsync);
        public ITcQuery<Investigations> Investigations => new TcQuery<Investigations>(this, GetAllInvestigationsAsync);
        //public TcQuery<Metrics> Metrics => new(this, GetAllMetricsAsync);
        //public TcQuery<Plugins> Plugins => new(this, GetAllPluginsAsync);
        public ITcQuery<Projects> Projects => new TcQuery<Projects>(this, GetAllProjectsAsync);
        public ITcQuery<Triggers> Triggers => new TcQuery<Triggers>(this, GetAllTriggersAsync);
        public ITcQuery<Users> Users => new TcQuery<Users>(this, GetAllUsersAsync);
        public ITcQuery<AgentPools> AgentPools => new TcQuery<AgentPools>(this, GetAllAgentPoolsAsync);
        public ITcQuery<AgentRequirements> AgentRequirements => new TcQuery<AgentRequirements>(this, GetAllAgentRequirementsAsync);
        public ITcQuery<ArtifactDependencies> ArtifactDependencies => new TcQuery<ArtifactDependencies>(this, GetAllArtifactDependenciesAsync);
        public ITcQuery<AuditEvents> AuditEvents => new TcQuery<AuditEvents>(this, GetAllAuditEventsAsync);
        public ITcQuery<Features> BuildFeatures => new TcQuery<Features>(this, GetAllBuildFeaturesAsync);
        public ITcQuery<Problems> BuildProblems => new TcQuery<Problems>(this, GetAllBuildProblemsAsync);
        public ITcQuery<Steps> BuildSteps => new TcQuery<Steps>(this, GetAllBuildStepsAsync);
        public ITcQuery<BuildTypes> BuildTemplates => new TcQuery<BuildTypes>(this, GetAllBuildTemplatesAsync);
        public ITcQuery<BuildTypes> BuildTypes => new TcQuery<BuildTypes>(this, GetAllBuildTypesAsync);
        public ITcQuery<CloudImages> Features => new TcQuery<CloudImages>(this, GetAllCloudImagesAsync);
        public ITcQuery<CloudInstances> CloudInstances => new TcQuery<CloudInstances>(this, GetAllCloudInstancesAsync);
        public ITcQuery<CloudProfiles> CloudProfiles => new TcQuery<CloudProfiles>(this, GetAllCloudProfilesAsync);
        public ITcQuery<Mutes> MutedTests => new TcQuery<Mutes>(this, GetAllMutedTestsAsync);
        public ITcQuery<Builds> QueuedBuilds => new TcQuery<Builds>(this, GetAllQueuedBuildsAsync);
        public ITcQuery<SnapshotDependencies> SnapshotDependencies => new TcQuery<SnapshotDependencies>(this, GetAllSnapshotDependenciesAsync);
        public ITcQuery<Projects> SubprojectsOrdered => new TcQuery<Projects>(this, GetAllSubprojectsOrderedAsync);
        public ITcQuery<TestOccurrences> TestOccurrences => new TcQuery<TestOccurrences>(this, GetAllTestOccurrencesAsync);
        public ITcQuery<Groups> UserGroups => new TcQuery<Groups>(this, GetAllUserGroupsAsync);
        //public TcQuery<Roles> UserRoles => new(this, GetAllUserRolesAsync);
        public ITcQuery<VcsRoots> VcsRoots => new TcQuery<VcsRoots>(this, GetAllVcsRootsAsync);
        //public TcQuery<Properties> BuildFeatureParameters => new(this, GetAllBuildFeatureParametersAsync);
        public ITcQuery<ProblemOccurrences> BuildProblemOccurrences => new TcQuery<ProblemOccurrences>(this, GetAllBuildProblemOccurrencesAsync);
        //public TcQuery<Properties> BuildStepParameters => new(this, GetAllBuildStepParametersAsync);
        public ITcQuery<BuildTypes> BuildTypesOrdered => new TcQuery<BuildTypes>(this, GetAllBuildTypesOrderedAsync);
        public ITcQuery<VcsRootInstances> VcsRootInstances => new TcQuery<VcsRootInstances>(this, GetAllVcsRootInstancesAsync);
        public ITcQuery<Properties> VcsRootProperties => new TcQuery<Properties>(this, GetAllVcsRootPropertiesAsync);
        //public TcQuery<Agents> AgentsFromAgentPool => new(this, GetAllAgentsFromAgentPoolAsync);
        //public TcQuery<Branches> BranchesOfBuildType => new(this, GetAllBranchesOfBuildTypeAsync);
        public ITcQuery<Investigations> InvestigationsOfBuild => new TcQuery<Investigations>(this, GetAllInvestigationsOfBuildTypeAsync);
        public ITcQuery<Projects> ProjectsFromAgentPool => new TcQuery<Projects>(this, GetAllProjectsFromAgentPoolAsync);
        public ITcQuery<VcsRootEntries> VcsRootsOfBuildType => new TcQuery<VcsRootEntries>(this, GetAllVcsRootsOfBuildTypeAsync);
    }
}
