var MongoClient = require('mongodb').MongoClient;


exports.store = function (sessionId, connectorResult) {

    var id = `${sessionId}`;
    var document = {
        "_id": id,
        "data": connectorResult
    };
    // Connection URL 
    var url = 'mongodb://localhost:27017/nodejs';
    // Use connect method to connect to the Server 
    MongoClient.connect(url, function (err, db) {
        console.log("Connected correctly to server");
        // Get the documents collection 
        var collection = db.collection('documents');
        // Insert some documents 
        collection.insertMany([
            document
        ], function (err, result) {
            console.log("Inserted 3 documents into the document collection");
            //callback(result);
        });
        db.close();
    });



    // var collection = _database.GetCollection<BsonDocument>("dotnet");
    // await collection.InsertOneAsync(document);
    // return true;
};