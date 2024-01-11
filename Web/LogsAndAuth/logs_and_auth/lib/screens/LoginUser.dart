import 'package:flutter/material.dart';
import 'package:dio/dio.dart';
import 'package:logs_and_auth/Models/LogsModel.dart';
import 'package:logs_and_auth/Models/StateUser.dart';
import 'package:provider/provider.dart';
import 'package:logs_and_auth/Repository/LogsRepository.dart';
import 'package:logs_and_auth/Repository/UserRepository.dart';
import 'package:http/http.dart' as http;



class AuthScreen extends StatefulWidget {
  @override
  _AuthScreenState createState() => _AuthScreenState();

 

  
}

class _AuthScreenState extends State<AuthScreen> {
  final TextEditingController loginController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final AuthRepository authRepository = AuthRepository();
  final LogRepository logRepository = LogRepository();
  String result = '';
 

Future<String> getIPAddress() async {
  return http.get(Uri.parse('https://api.ipify.org')).then((response) {
    return response.body;
  });
}
  Future<void> handleLogin() async {
    String login = loginController.text;
    String password = passwordController.text;
    try {
      Dio dio = Dio();
      String response = await authRepository.Login(password, login, dio);
      setState(() {
        result = response;
         // Устанавливаем isAdmin в true, если логин и пароль совпадают
       Provider.of<UserState>(context, listen: false).setAdmin(login == 'V' && password == '3');
      });

      // Отправка ответа сервера по логам
      String ip = await getIPAddress(); // Замените на реальный IP
      String route = 'Otvet'; // Замените на реальный маршрут
      await logRepository.sendLog(result, ip, dio, route);
    } catch (e) {
      setState(() {
        result = 'Ошибка: $e';
      });
    }
   
  }

  

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Авторизация'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            TextField(
              controller: loginController,
              decoration: InputDecoration(
                labelText: 'Логин',
              ),
            ),
            SizedBox(height: 16.0),
            TextField(
              controller: passwordController,
              decoration: InputDecoration(
                labelText: 'Пароль',
              ),
              obscureText: true,
            ),
            SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: handleLogin,
              child: Text('Войти'),
            ),
            SizedBox(height: 16.0),
            Text(result), // Вывод ответа от сервера
          ],
        ),
      ),
    );
  }
}