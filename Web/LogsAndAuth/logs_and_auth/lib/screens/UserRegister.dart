import 'package:flutter/material.dart';
import 'package:dio/dio.dart';
import 'package:logs_and_auth/Models/LogsModel.dart';
import 'package:logs_and_auth/Repository/UserRepository.dart';

class RegistrationScreen extends StatelessWidget {
  final TextEditingController loginController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final TextEditingController nameController = TextEditingController();
  final TextEditingController emailController = TextEditingController();
  final TextEditingController phoneController = TextEditingController();
  final AuthRepository authRepository = AuthRepository();

  Future<void> handleRegistration() async {
    String login = loginController.text;
    String password = passwordController.text;
    String name = nameController.text;
    String email = emailController.text;
    String phone = phoneController.text;

    try {
      Dio dio = Dio(); // Создайте экземпляр Dio
      String result = await authRepository.Registration(password, login, name, email, phone, dio);
      // Обработайте результат
      print(result);
    } catch (e) {
      // Обработайте ошибку
      print('Ошибка: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Регистрация'),
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
            TextField(
              controller: nameController,
              decoration: InputDecoration(
                labelText: 'Имя',
              ),
            ),
            SizedBox(height: 16.0),
            TextField(
              controller: emailController,
              decoration: InputDecoration(
                labelText: 'Email',
              ),
            ),
            SizedBox(height: 16.0),
            TextField(
              controller: phoneController,
              decoration: InputDecoration(
                labelText: 'Телефон',
              ),
            ),
            SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: handleRegistration, // Вызовите функцию handleRegistration при нажатии кнопки
              child: Text('Зарегистрироваться'),
            ),
          ],
        ),
      ),
    );
  }
}