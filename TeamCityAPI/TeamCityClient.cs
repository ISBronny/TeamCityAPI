using System.Net.Http.Headers;
using System.Text;
using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries;
using TeamCityAPI.Queries.Common;
using TeamCityAPI.Queries.Interfaces;
using Type = System.Type;

namespace TeamCityAPI
{
    public class Settings
    {
        public IncludeType DefaultIncludeType { get; set; } = IncludeType.Short;
    }

    public partial class TeamCityClient
    {
        public Settings Settings { get; set; }

        public TeamCityClient(string baseUrl)
        {
            BaseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue {NoCache = true};
            _serializerSettings = new Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
            Settings = new Settings();
        }

        public void UseLoginAndPass(string user, string password)
        {
            var credentials = Encoding.ASCII.GetBytes($"{user}:{password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

        }

        public void UseToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        //ToDo:
        //Uncomment
        public ITcPagedQuery<Agents> Agents => new TcPagedQuery<Agents>(this, GetAllAgentsAsync);

        //public ITcQuery<Branches> Branches => new TcQuery<Branches>(this, GetAllBranchesAsync);
        public ITcPagedQuery<Builds> Builds => new TcPagedQuery<Builds>(this, GetAllBuildsAsync);
        public ITcPagedQuery<Changes> Changes => new TcPagedQuery<Changes>(this, GetAllChangesAsync);
        public ITcQuery<Groups> Groups => new TcQuery<Groups>(this, (_, fields) => GetAllGroupsAsync(fields));
        public ITcQuery<Investigations> Investigations => new TcQuery<Investigations>(this, GetAllInvestigationsAsync);
        public ITcQuery<Metrics> Metrics => new TcQuery<Metrics>(this, (_, fields) => GetAllMetricsAsync(fields));
        public ITcQuery<Plugins> Plugins => new TcQuery<Plugins>(this, (_, fields) => GetAllPluginsAsync(fields));
        public ITcPagedQuery<Projects> Projects => new TcPagedQuery<Projects>(this, GetAllProjectsAsync);
        public ITcQuery<Triggers> Triggers => new TcQuery<Triggers>(this, GetAllTriggersAsync);
        public ITcQuery<Users> Users => new TcQuery<Users>(this, GetAllUsersAsync);
        public ITcQuery<AgentPools> AgentPools => new TcQuery<AgentPools>(this, GetAllAgentPoolsAsync);

        public ITcQuery<AgentRequirements> AgentRequirements =>
            new TcQuery<AgentRequirements>(this, GetAllAgentRequirementsAsync);

        public ITcQuery<ArtifactDependencies> ArtifactDependencies =>
            new TcQuery<ArtifactDependencies>(this, GetAllArtifactDependenciesAsync);

        public ITcPagedQuery<AuditEvents> AuditEvents => new TcPagedQuery<AuditEvents>(this, GetAllAuditEventsAsync);
        public ITcQuery<Features> BuildFeatures => new TcQuery<Features>(this, GetAllBuildFeaturesAsync);
        public ITcPagedQuery<Problems> BuildProblems => new TcPagedQuery<Problems>(this, GetAllBuildProblemsAsync);
        public ITcQuery<Steps> BuildSteps => new TcQuery<Steps>(this, GetAllBuildStepsAsync);

        public ITcPagedQuery<BuildTypes> BuildTemplates =>
            new TcPagedQuery<BuildTypes>(this, GetAllBuildTemplatesAsync);

        public ITcPagedQuery<BuildTypes> BuildTypes => new TcPagedQuery<BuildTypes>(this, GetAllBuildTypesAsync);
        public ITcQuery<CloudImages> Features => new TcQuery<CloudImages>(this, GetAllCloudImagesAsync);
        public ITcQuery<CloudInstances> CloudInstances => new TcQuery<CloudInstances>(this, GetAllCloudInstancesAsync);
        public ITcQuery<CloudProfiles> CloudProfiles => new TcQuery<CloudProfiles>(this, GetAllCloudProfilesAsync);
        public ITcPagedQuery<Mutes> MutedTests => new TcPagedQuery<Mutes>(this, GetAllMutedTestsAsync);
        public ITcQuery<Builds> QueuedBuilds => new TcQuery<Builds>(this, GetAllQueuedBuildsAsync);

        public ITcQuery<SnapshotDependencies> SnapshotDependencies =>
            new TcQuery<SnapshotDependencies>(this, GetAllSnapshotDependenciesAsync);

        public ITcPagedQuery<Projects> SubprojectsOrdered =>
            new TcPagedQuery<Projects>(this, GetAllSubprojectsOrderedAsync);

        public ITcPagedQuery<TestOccurrences> TestOccurrences =>
            new TcPagedQuery<TestOccurrences>(this, GetAllTestOccurrencesAsync);

        public ITcQuery<Groups> UserGroups => new TcQuery<Groups>(this, GetAllUserGroupsAsync);

        //public TcQuery<Roles> UserRoles => new(this, GetAllUserRolesAsync);
        public ITcPagedQuery<VcsRoots> VcsRoots => new TcPagedQuery<VcsRoots>(this, GetAllVcsRootsAsync);

        //public TcQuery<Properties> BuildFeatureParameters => new(this, GetAllBuildFeatureParametersAsync);
        public ITcPagedQuery<ProblemOccurrences> BuildProblemOccurrences =>
            new TcPagedQuery<ProblemOccurrences>(this, GetAllBuildProblemOccurrencesAsync);

        //public TcQuery<Properties> BuildStepParameters => new(this, GetAllBuildStepParametersAsync);
        public ITcQuery<BuildTypes> BuildTypesOrdered => new TcQuery<BuildTypes>(this, GetAllBuildTypesOrderedAsync);

        public ITcPagedQuery<VcsRootInstances> VcsRootInstances =>
            new TcPagedQuery<VcsRootInstances>(this, GetAllVcsRootInstancesAsync);

        public ITcQuery<Properties> VcsRootProperties => new TcQuery<Properties>(this, GetAllVcsRootPropertiesAsync);

        //public TcQuery<Agents> AgentsFromAgentPool => new(this, GetAllAgentsFromAgentPoolAsync);
        //public TcQuery<Branches> BranchesOfBuildType => new(this, GetAllBranchesOfBuildTypeAsync);
        public ITcPagedQuery<Investigations> InvestigationsOfBuild =>
            new TcPagedQuery<Investigations>(this, GetAllInvestigationsOfBuildTypeAsync);

        public ITcPagedQuery<Projects> ProjectsFromAgentPool =>
            new TcPagedQuery<Projects>(this, GetAllProjectsFromAgentPoolAsync);

        public ITcQuery<VcsRootEntries> VcsRootsOfBuildType =>
            new TcQuery<VcsRootEntries>(this, GetAllVcsRootsOfBuildTypeAsync);
        
         public async Task<T> GetPage<T>(string href, Type deserializeType) where T : Page
         {

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var url_ = BaseUrl + href;
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<T>(response_, headers_, deserializeType).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                            }
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }
         
         private async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, Type type)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }
        
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = (T)Newtonsoft.Json.JsonConvert.DeserializeObject(responseText, type, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }
    }
}