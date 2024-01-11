import 'package:flutter/material.dart';
import 'package:logs_and_auth/Models/StateUser.dart';
import 'package:logs_and_auth/screens/GetLogs.dart';
import 'package:logs_and_auth/screens/LoginUser.dart'; 
import 'package:logs_and_auth/screens/UserRegister.dart'; 
import 'package:provider/provider.dart';


class StartScreen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Добро пожаловать'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            ElevatedButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => AuthScreen(),
                  ),
                );
              },
              child: Text('Авторизация'),
            ),
            SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => RegistrationScreen(),
                  ),
                );
              },
              child: Text('Регистрация'),
            ),
            SizedBox(height: 16.0),
           ElevatedButton(
    onPressed: () async {
      final isAdmin = Provider.of<UserState>(context, listen: false).isAdmin;

      if (isAdmin) {
        Navigator.push(
          context,
          MaterialPageRoute(
            builder: (context) => LogTable(),
          ),
        );
      } else {
        // Пользователь не является администратором
        // Можно показать сообщение или выполнить другие действия
      }
    },
    child: Text('Открыть логи'),
            ),
          ],
        ),
      ),
    );
  }
}
