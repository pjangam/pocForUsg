exports.healthCheck = function(req, res, next) {
	console.log('This message is intentionally placed here.');
	return res.json({
		status: '200',
		message: 'Ok'
	});
};