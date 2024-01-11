import 'package:flutter/material.dart';
import 'package:logs_and_auth/Models/LogsModel.dart';
import 'package:logs_and_auth/Repository/LogsRepository.dart';

class LogTable extends StatelessWidget {
  final LogRepository logRepository = LogRepository();
  late Future<List<LogModel>> logs;

  LogTable() {
    logs = logRepository.getLogs();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Log Table'),
      ),
      body: SingleChildScrollView( // Wrap with SingleChildScrollView
        child: FutureBuilder<List<LogModel>>(
          future: logs,
          builder: (context, snapshot) {
            if (snapshot.connectionState == ConnectionState.waiting) {
              return CircularProgressIndicator();
            } else if (snapshot.hasError) {
              return Text('Error: ${snapshot.error}');
            } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
              return Text('No logs available');
            } else {
              return DataTable(
                columns: [
                  DataColumn(label: Text('id')),
                  DataColumn(label: Text('message')),
                  DataColumn(label: Text('date')),
                  DataColumn(label: Text('ip')),
                  DataColumn(label: Text('route')),
                ],
                rows: snapshot.data!
                    .map(
                      (log) => DataRow(cells: [
                        DataCell(Text(log.id.toString())),
                        DataCell(Text(log.message.toString())),
                        DataCell(Text(log.date.toString())),
                        DataCell(Text(log.ip.toString())),
                        DataCell(Text(log.route.toString())),
                      ]),
                    )
                    .toList(),
              );
            }
          },
        ),
      ),
    );
  }
}
