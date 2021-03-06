﻿using System;
using Learning.CSharp.Utilities;
using MongoDB.Driver;

namespace Learning.CSharp.MongoStore
{

    public class MongoDataStore
    {
        #region Variables.
        private static readonly MongoClient DataStoreClient;
        private static readonly IMongoDatabase DesignPatternDatabase;
        #endregion

        private MongoDataStore() { }

        static MongoDataStore()
        {
            var mongoDbConnectionString = ConfigurationHelper.GetConfigurationValue("MongoDbConnectionString");
            Console.WriteLine(mongoDbConnectionString);
            DataStoreClient = new MongoClient(mongoDbConnectionString);

            //Data Base
            var mongoDbDatabaseName = ConfigurationHelper.GetConfigurationValue("MongoDbDatabaseName");
            DesignPatternDatabase = DataStoreClient.GetDatabase(mongoDbDatabaseName);
        }

        #region Properties
        public static MongoDataStore DataStoreInstance { get; } = new MongoDataStore();

        public MongoClient MongoDataStoreClient => DataStoreClient;

        public IMongoDatabase DatabaseInstance => DesignPatternDatabase;
        #endregion
    }

}
