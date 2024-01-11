import 'dart:convert';


import 'package:flutter/material.dart';
import 'package:flutter_api/utils/api_endpoints.dart';
import 'package:get/get.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:http/http.dart' as http;

 class RegistrationController extends GetxController{
  TextEditingController loginController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController firstNameController = TextEditingController();
  TextEditingController middleNameController = TextEditingController();
  TextEditingController lastNameController = TextEditingController();
  TextEditingController mailController = TextEditingController();
  TextEditingController phoneController = TextEditingController();

  final Future<SharedPreferences> _prefs = SharedPreferences.getInstance();

Future<void> registerWithEmail() async{
  try {
    var headers = {'Content_Type': 'application/json'};
    var url = Uri.parse(
      ApiEndPoints.baseUrl + ApiEndPoints.authEndpoints.registerEmail);
    Map body = {
      'login': loginController.text,
      'password': passwordController.text,
      'firstName': firstNameController.text,
      'middleName': middleNameController.text,
      'lastName':lastNameController.text,
      'mail': mailController.text.trim(),
      'PhoneNumber': phoneController.text
    };

    http.Response response = 
      await http.post(url,body: jsonEncode(body),headers:headers);

    if (response.statusCode == 200) {
      final json = jsonDecode(response.body);
      if (json['code'] == 0) {
        var token = json['data']['token'];
        print(token);
        final SharedPreferences? prefs = await _prefs;

        await prefs?.setString('token', token);
        loginController.clear();
        passwordController.clear();
        firstNameController.clear();
        middleNameController.clear();
        lastNameController.clear();
        mailController.clear();
        phoneController.clear();
      }else {
        throw jsonDecode(response.body)["message"] ?? "Неизвестная ошибка";
      }
    }
  }catch (e) {
    Get.back();
    showDialog(
      context:Get.context!, 
      builder: (context){
        return SimpleDialog(
          title: Text('Error'),
          contentPadding: EdgeInsets.all(20),
          children: [Text(e.toString())],
        );
      });
  }
}
}

