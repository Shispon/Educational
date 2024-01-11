import 'package:dio/dio.dart';
import 'package:logs_and_auth/Models/UserModel.dart';

class AuthRepository {
  Future<String> Registration(String password, String login,String name,String mail,String phone, Dio dio) async {
    var url =
        'https://localhost:5021/api/Auth/register?login=${login}&name=${name}&mail=${mail}&password=${password}&phone=${phone}'; // Замените на свой URL

    try {
      var response = await dio.post(
        url,
      );

      print('JSON отправлен успешно');
      final data = response.data;
      return data.toString();
    } catch (e) {
      throw Exception('Failed to load: $e');
    }
  }

 Future<String> Login(String password, String login, Dio dio) async {
  var url = 'http://localhost:5021/api/Auth/login?login=${login}&password=${password}';
  try {
    var response = await dio.post(
      url,
    );
    print('JSON отправлен успешно');
    final data = response.data;
    return data.toString();
  } catch (e) {
    if (e is DioError) {
      var dioError = e as DioError;
      if (dioError.response != null && dioError.response!.statusCode == 400) {
        return 'Неверный логин или пароль';
      }
      print('Response: ${dioError.response}');
      print('Response Data: ${dioError.response?.data}');
    }
    throw Exception('Failed to load: $e');
  }
}
}