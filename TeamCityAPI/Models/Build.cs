namespace TeamCityAPI
{
    /// <summary>Represents a build instance.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Build 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("taskId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TaskId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildTypeId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypeInternalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildTypeInternalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildState? State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("running", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Running { get; set; }
    
        [Newtonsoft.Json.JsonProperty("composite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Composite { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failedToStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FailedToStart { get; set; }
    
        [Newtonsoft.Json.JsonProperty("personal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Personal { get; set; }
    
        [Newtonsoft.Json.JsonProperty("percentageComplete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PercentageComplete { get; set; }
    
        [Newtonsoft.Json.JsonProperty("branchName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("defaultBranch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DefaultBranch { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unspecifiedBranch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UnspecifiedBranch { get; set; }
    
        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? History { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pinned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Pinned { get; set; }
    
        [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Href { get; set; }
    
        [Newtonsoft.Json.JsonProperty("webUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WebUrl { get; set; }
    
        [Newtonsoft.Json.JsonProperty("queuePosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? QueuePosition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("limitedChangesCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LimitedChangesCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifactsDirectory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArtifactsDirectory { get; set; }
    
        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Links Links { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statusText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusText { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildType BuildType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Comment Comment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Tags Tags { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pinInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Comment PinInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User User { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startEstimate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartEstimate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("waitReason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaitReason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("finishEstimate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FinishEstimate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("delayedByBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Build DelayedByBuild { get; set; }
    
        [Newtonsoft.Json.JsonProperty("plannedAgent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Agent PlannedAgent { get; set; }
    
        [Newtonsoft.Json.JsonProperty("running-info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProgressInfo RunningInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("canceledInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Comment CanceledInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("queuedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QueuedDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("finishDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FinishDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("triggered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TriggeredBy Triggered { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastChanges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Changes LastChanges { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Changes Changes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("revisions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Revisions Revisions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("versionedSettingsRevision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Revision VersionedSettingsRevision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifactDependencyChanges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildChanges ArtifactDependencyChanges { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Agent Agent { get; set; }
    
        [Newtonsoft.Json.JsonProperty("compatibleAgents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Agents CompatibleAgents { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testOccurrences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TestOccurrences TestOccurrences { get; set; }
    
        [Newtonsoft.Json.JsonProperty("problemOccurrences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProblemOccurrences ProblemOccurrences { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifacts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Files Artifacts { get; set; }
    
        [Newtonsoft.Json.JsonProperty("relatedIssues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IssuesUsages RelatedIssues { get; set; }
    
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties Properties { get; set; }
    
        [Newtonsoft.Json.JsonProperty("resultingProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties ResultingProperties { get; set; }
    
        [Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Entries Attributes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statistics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties Statistics { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Datas Metadata { get; set; }
    
        [Newtonsoft.Json.JsonProperty("snapshot-dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Builds SnapshotDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifact-dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Builds ArtifactDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("custom-artifact-dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ArtifactDependencies CustomArtifactDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("settingsHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SettingsHash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currentSettingsHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrentSettingsHash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("modificationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModificationId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("chainModificationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChainModificationId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("replacementIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Items ReplacementIds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("related", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Related Related { get; set; }
    
        [Newtonsoft.Json.JsonProperty("triggeringOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTriggeringOptions TriggeringOptions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedByOtherBuilds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UsedByOtherBuilds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statusChangeComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Comment StatusChangeComment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vcsLabels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<VcsLabel> VcsLabels { get; set; }
    
        [Newtonsoft.Json.JsonProperty("detachedFromAgent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DetachedFromAgent { get; set; }
    
        [Newtonsoft.Json.JsonProperty("finishOnAgentDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FinishOnAgentDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("customized", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Customized { get; set; }
    
        [Newtonsoft.Json.JsonProperty("customization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customizations Customization { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changesCollectingInProgress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ChangesCollectingInProgress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("locator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Locator { get; set; }
    
    
    }
}