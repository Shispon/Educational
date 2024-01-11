class ApiEndPoints {
  static final String baseUrl = 'http://localhost:18212/';
  static _AuthEndPoints authEndpoints = _AuthEndPoints();
}

class _AuthEndPoints {
  final String registerEmail = 'api/User/insertUser';
  final String loginEmail = 'api/User/login';
}