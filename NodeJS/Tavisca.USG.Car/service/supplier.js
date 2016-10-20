exports.search = function () {
    return new Promise((resolve, reject) => {
        var res = require('./../data/searchResult.json');
        resolve(res);
    });
};