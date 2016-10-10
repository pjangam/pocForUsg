exports.setup = function (app) {
    var express = require('express');


    var hotelApi = require('../service/hotel');

    var apiServer = express();

    var healthCheckApi = require('../service/healthCheck');

    // By default all request are cached on client side, to avoid this for API, add cacheLayer.noCacheRequest
    apiServer.get('/:connector/hotels/v1.0/healthcheck', cacheLayer.noCacheRequest, preAuth.verifyConnector, healthCheckApi.healthCheck);


    var prePostValidator = require('../validators/prePostValidator');

    apiServer.get('/mock', cacheLayer.noCacheRequest, mockApi.mock);
    apiServer.post('/:connector/hotels/v1.0/search', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preSearch, requestValidator.validateSearch, hotelApi.search, prePostValidator.postSearch, responseFilter.filterSearch);
    apiServer.post('/:connector/hotels/v1.0/getroomrates', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preGetRoomRates, requestValidator.validateRoomRates, hotelApi.getRoomRates, prePostValidator.postGetRoomRates, responseFilter.filterRoomRates);
    apiServer.post('/:connector/hotels/v1.0/getraterules', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preGetRateRules, requestValidator.validateRateRules, hotelApi.getRateRules, prePostValidator.postGetRateRules, responseFilter.filterRateRules);
    apiServer.post('/:connector/hotels/v1.0/book', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preBook, requestValidator.validateBook, hotelApi.book, prePostValidator.postBook, responseFilter.filterBook);
    apiServer.post('/:connector/hotels/v1.0/cancel', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preCancel, requestValidator.validateCancel, hotelApi.cancel, prePostValidator.postCancel, responseFilter.filterCancel);
    apiServer.get('/:connector/hotels/v1.0/getmetadata', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preGetMetaData, requestValidator.validateMetaData, hotelApi.getMetaData, prePostValidator.postGetMetaData, responseFilter.filterMetaData);
    apiServer.get('/:connector/hotels/v1.0/getconfigurationspec', cacheLayer.noCacheRequest, preAuth.verifyConnector, prePostValidator.preGetConfigurationSpec, requestValidator.validateConfigurationSpec, hotelApi.getConfigurationSpec, prePostValidator.postGetConfigurationSpec, responseFilter.filterConfigurationSpec);


    app.use('/connector', apiServer);
};
