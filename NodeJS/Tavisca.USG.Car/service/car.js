var uuid = require('uuid');


exports.searchinit = function (req, res, next) {
    var sessionId = uuid();
    res.json();
    for (var index = 0; index < 15; index++) {
        var randomNumber = getRandomIntInclusive(10, 15);
        setInterval(function () {
            var supplier = require('./supplier.js');
            var resultFuture = supplier.search(req);
            var dal = require('./dal.js');
            resultFuture.then((connectorResult) => dal.store(sessionId, connectorResult));
        }, randomNumber);
    }


};

exports.searchresult = function (req, res, next) {

};


function getRandomIntInclusive(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}