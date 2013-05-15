import 'dart:async';
import 'package:web_ui/web_ui.dart';

@observable String currentTime;

void main() {
  var oneSecond = new Duration(seconds:1);
  new Timer.periodic(oneSecond, updateTime);
  updateTime(null);
}

void updateTime(Timer _) {
  DateTime today = new DateTime.now();
  currentTime = formatTime(today.hour, today.minute, today.second);
}

String formatTime(int h, int m, int s) {
  if (h > 12) {
    h = h -12;
  }
  String minute = (m <= 9) ? '0$m' : '$m';
  String second = (s <= 9) ? '0$s' : '$s';
  return '$h:$minute:$second';
}
