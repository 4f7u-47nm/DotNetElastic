// See https://aka.ms/new-console-template for more information

using System.Net.NetworkInformation;
using Elasticsearch.Net;
using Nest;

Console.WriteLine("Hello, World!");


var test = new ElasticClient();

var sd = new ElasticLowLevelClient();

var df = new ElasticLowLevelClient();

var sdf = new ElasticsearchUrlFormatter(null);

var sf = new UserAgentProcessor();

new ElasticsearchClientException("");


