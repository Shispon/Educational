import 'package:flutter/material.dart';
import 'package:logs_and_auth/Models/StateUser.dart';
import 'package:logs_and_auth/screens/GetLogs.dart';
import 'package:logs_and_auth/screens/LoginUser.dart';
import 'package:logs_and_auth/screens/RegisterLogin.dart';
import 'package:logs_and_auth/screens/UserRegister.dart';
import 'package:provider/provider.dart';


void main() {
  runApp(
    ChangeNotifierProvider(
      create: (context) => UserState(),
      child: MyApp(),
    ),
  );
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Your App',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      initialRoute: '/',
      routes: {
        '/': (context) => StartScreen(),
        '/auth': (context) => AuthScreen(),
        '/registration': (context) => RegistrationScreen(),
        '/GetLogs': (context) => LogTable(),
      },
    );
  }
}
