class UserModel {
  int? Id;
  String? Login;
  String? Name;
  String? Email;
  String? Password;
  String? Phone;

  UserModel({ this.Id,this.Login,this.Name,this.Email,this.Password,this.Phone});

  UserModel.fromJson(Map<String, dynamic> json) {
    Id = json['id'];
    Login = json['login'];
    Name = json['name'];
    Email = json['mail'];
    Password = json['password'];
    Phone = json['phone_number'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.Id;
    data['login'] = this.Login;
    data['name'] = this.Name;
    data['mail'] = this.Email;
    data['password'] = this.Password;
    data['phone_number'] = this.Phone;
    return data;
  }
}