
using Microsoft.Extensions.Logging;
using Nethereum.Web3;
using NLog.Extensions.Logging;

var logger = LoggerFactory.Create(builder => builder.AddNLog()).CreateLogger<Program>();
logger.LogInformation("hello info!");
logger.LogTrace("hello trace!");
var web3 = new Web3("http://localhost:8545", logger);
var blocknumber = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
Console.ReadLine();