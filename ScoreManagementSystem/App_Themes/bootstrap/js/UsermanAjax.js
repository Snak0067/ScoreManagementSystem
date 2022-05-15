
// Provide a default path to dwr.engine
if (dwr == null) var dwr = {};
if (dwr.engine == null) dwr.engine = {};
if (DWREngine == null) var DWREngine = dwr.engine;

if (UsermanAjax == null) var UsermanAjax = {};
UsermanAjax._path = '/zfca/dwr';
UsermanAjax.getYhlx = function(p0, p1, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'getYhlx', p0, p1, callback);
}
UsermanAjax.moditime = function(p0, p1, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'moditime', p0, p1, callback);
}
UsermanAjax.getTysfyhb = function(p0, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'getTysfyhb', p0, callback);
}
UsermanAjax.validateLoginUser = function(p0, p1, p2, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'validateLoginUser', p0, p1, p2, false, callback);
}
UsermanAjax.validateYzm = function(p0, p1, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'validateYzm', p0, p1, callback);
}
UsermanAjax.checkAccount = function(p1, p2, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'checkAccount', false, p1, p2, callback);
}
UsermanAjax.checkRetakepw = function(p0, p1, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'checkRetakepw', p0, p1, callback);
}
UsermanAjax.chkmm = function(p0, p1, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'chkmm', p0, p1, callback);
}
UsermanAjax.checkNewPwd = function(p0, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'checkNewPwd', p0, callback);
}
UsermanAjax.modifypwd = function(p0, p1, p2, callback) {
  dwr.engine._execute(UsermanAjax._path, 'UsermanAjax', 'modifypwd', p0, p1, p2, false, callback);
}