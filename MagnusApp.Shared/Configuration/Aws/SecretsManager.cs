﻿using Amazon.SecretsManager.Model;
using Amazon.SecretsManager;

namespace MagnusApp.Shared.Configuration.Aws;

//Add interface of this class for dependency injection purposes
public static class GoogleSecret
{
    public static async Task<string> GetClientId()
    {
        IAmazonSecretsManager secretsManager = new AmazonSecretsManagerClient(Amazon.RegionEndpoint.AFSouth1);
        var idrequest = new GetSecretValueRequest
        {
            SecretId = "Google_ClientId"
        };
        return (await secretsManager.GetSecretValueAsync(idrequest)).SecretString;
    }

    public static async Task<string> GetClientSecret()
    {
        IAmazonSecretsManager secretsManager = new AmazonSecretsManagerClient(Amazon.RegionEndpoint.AFSouth1);
        var request = new GetSecretValueRequest
        {
            SecretId = "Google_ClientSecret"
        };
        return (await secretsManager.GetSecretValueAsync(request)).SecretString;
    }
}
public static class DatabaseSecret
{
    public static async Task<string> GetConnectionString()
    {
        IAmazonSecretsManager secretsManager = new AmazonSecretsManagerClient(Amazon.RegionEndpoint.AFSouth1);
        var request = new GetSecretValueRequest()
        {
            SecretId = "AWSMagnusAppConnectionString"
        };
        return (await secretsManager.GetSecretValueAsync(request)).SecretString;
    }
}
public static class ApplicationSecret
{
}
