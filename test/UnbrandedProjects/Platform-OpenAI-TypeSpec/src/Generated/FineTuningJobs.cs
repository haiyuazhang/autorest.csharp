// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The FineTuningJobs sub-client. </summary>
    public partial class FineTuningJobs
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FineTuningJobs for mocking. </summary>
        protected FineTuningJobs()
        {
        }

        /// <summary> Initializes a new instance of FineTuningJobs. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> Service host. </param>
        internal FineTuningJobs(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the
        /// fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="job"> The <see cref="CreateFineTuningJobRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="job"/> is null. </exception>
        public virtual async Task<ClientResult<FineTuningJob>> CreateAsync(CreateFineTuningJobRequest job)
        {
            Argument.AssertNotNull(job, nameof(job));

            using BinaryContent content = job.ToBinaryContent();
            ClientResult result = await CreateAsync(content, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the
        /// fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="job"> The <see cref="CreateFineTuningJobRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="job"/> is null. </exception>
        public virtual ClientResult<FineTuningJob> Create(CreateFineTuningJobRequest job)
        {
            Argument.AssertNotNull(job, nameof(job));

            using BinaryContent content = job.ToBinaryContent();
            ClientResult result = Create(content, null);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the
        /// fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(CreateFineTuningJobRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the
        /// fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(CreateFineTuningJobRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Create(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Get paginateds. </summary>
        /// <param name="after"> Identifier for the last job from the previous pagination request. </param>
        /// <param name="limit"> Number of fine-tuning jobs to retrieve. </param>
        public virtual async Task<ClientResult<ListPaginatedFineTuningJobsResponse>> GetPaginatedsAsync(string after = null, long? limit = null)
        {
            ClientResult result = await GetPaginatedsAsync(after, limit, null).ConfigureAwait(false);
            return ClientResult.FromValue(ListPaginatedFineTuningJobsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Get paginateds. </summary>
        /// <param name="after"> Identifier for the last job from the previous pagination request. </param>
        /// <param name="limit"> Number of fine-tuning jobs to retrieve. </param>
        public virtual ClientResult<ListPaginatedFineTuningJobsResponse> GetPaginateds(string after = null, long? limit = null)
        {
            ClientResult result = GetPaginateds(after, limit, null);
            return ClientResult.FromValue(ListPaginatedFineTuningJobsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get paginateds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetPaginatedsAsync(string,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="after"> Identifier for the last job from the previous pagination request. </param>
        /// <param name="limit"> Number of fine-tuning jobs to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetPaginatedsAsync(string after, long? limit, RequestOptions options)
        {
            using PipelineMessage message = CreateGetPaginatedsRequest(after, limit, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get paginateds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetPaginateds(string,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="after"> Identifier for the last job from the previous pagination request. </param>
        /// <param name="limit"> Number of fine-tuning jobs to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetPaginateds(string after, long? limit, RequestOptions options)
        {
            using PipelineMessage message = CreateGetPaginatedsRequest(after, limit, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary>
        /// Get info about a fine-tuning job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId"> The <see cref="string"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Retrieve. </remarks>
        public virtual async Task<ClientResult<FineTuningJob>> RetrieveAsync(string fineTuningJobId)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = await RetrieveAsync(fineTuningJobId, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Get info about a fine-tuning job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId"> The <see cref="string"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Retrieve. </remarks>
        public virtual ClientResult<FineTuningJob> Retrieve(string fineTuningJobId)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = Retrieve(fineTuningJobId, null);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get info about a fine-tuning job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> RetrieveAsync(string fineTuningJobId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateRetrieveRequest(fineTuningJobId, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get info about a fine-tuning job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Retrieve(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The <see cref="string"/> to use. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Retrieve(string fineTuningJobId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateRetrieveRequest(fineTuningJobId, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Get status updates for a fine-tuning job. </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to get events for. </param>
        /// <param name="after"> Identifier for the last event from the previous pagination request. </param>
        /// <param name="limit"> Number of events to retrieve. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Get events. </remarks>
        public virtual async Task<ClientResult<ListFineTuningJobEventsResponse>> GetEventsAsync(string fineTuningJobId, string after = null, long? limit = null)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = await GetEventsAsync(fineTuningJobId, after, limit, null).ConfigureAwait(false);
            return ClientResult.FromValue(ListFineTuningJobEventsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Get status updates for a fine-tuning job. </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to get events for. </param>
        /// <param name="after"> Identifier for the last event from the previous pagination request. </param>
        /// <param name="limit"> Number of events to retrieve. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Get events. </remarks>
        public virtual ClientResult<ListFineTuningJobEventsResponse> GetEvents(string fineTuningJobId, string after = null, long? limit = null)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = GetEvents(fineTuningJobId, after, limit, null);
            return ClientResult.FromValue(ListFineTuningJobEventsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get status updates for a fine-tuning job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEventsAsync(string,string,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to get events for. </param>
        /// <param name="after"> Identifier for the last event from the previous pagination request. </param>
        /// <param name="limit"> Number of events to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetEventsAsync(string fineTuningJobId, string after, long? limit, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateGetEventsRequest(fineTuningJobId, after, limit, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get status updates for a fine-tuning job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEvents(string,string,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to get events for. </param>
        /// <param name="after"> Identifier for the last event from the previous pagination request. </param>
        /// <param name="limit"> Number of events to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetEvents(string fineTuningJobId, string after, long? limit, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateGetEventsRequest(fineTuningJobId, after, limit, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Immediately cancel a fine-tune job. </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to cancel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Cancel. </remarks>
        public virtual async Task<ClientResult<FineTuningJob>> CancelAsync(string fineTuningJobId)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = await CancelAsync(fineTuningJobId, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Immediately cancel a fine-tune job. </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to cancel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Cancel. </remarks>
        public virtual ClientResult<FineTuningJob> Cancel(string fineTuningJobId)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            ClientResult result = Cancel(fineTuningJobId, null);
            return ClientResult.FromValue(FineTuningJob.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Immediately cancel a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CancelAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to cancel. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CancelAsync(string fineTuningJobId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateCancelRequest(fineTuningJobId, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Immediately cancel a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Cancel(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuningJobId"> The ID of the fine-tuning job to cancel. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuningJobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuningJobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Cancel(string fineTuningJobId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuningJobId, nameof(fineTuningJobId));

            using PipelineMessage message = CreateCancelRequest(fineTuningJobId, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateCreateRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine_tuning/jobs", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetPaginatedsRequest(string after, long? limit, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine_tuning/jobs", false);
            if (after != null)
            {
                uri.AppendQuery("after", after, true);
            }
            if (limit != null)
            {
                uri.AppendQuery("limit", limit.Value, true);
            }
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateRetrieveRequest(string fineTuningJobId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine_tuning/jobs/", false);
            uri.AppendPath(fineTuningJobId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetEventsRequest(string fineTuningJobId, string after, long? limit, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine_tuning/jobs/", false);
            uri.AppendPath(fineTuningJobId, true);
            uri.AppendPath("/events", false);
            if (after != null)
            {
                uri.AppendQuery("after", after, true);
            }
            if (limit != null)
            {
                uri.AppendQuery("limit", limit.Value, true);
            }
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCancelRequest(string fineTuningJobId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine_tuning/jobs/", false);
            uri.AppendPath(fineTuningJobId, true);
            uri.AppendPath("/cancel", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
