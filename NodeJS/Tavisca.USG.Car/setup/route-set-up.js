exports.setup = function (app) {
    var express = require('express');
    var apiServer = express();
    var cacheLayer = require('./cache-control.js');
    var carService = require('./../service/car.js');
    apiServer.post('/:connector/hotels/v1.0/search/init', cacheLayer.noCacheRequest, carService.searchinit);
    apiServer.post('/:connector/hotels/v1.0/search/result', cacheLayer.noCacheRequest, carService.searchresult);

    app.use('/connector', apiServer);
};
