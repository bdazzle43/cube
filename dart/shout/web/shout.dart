import 'dart:html';

@observable
String shoutThis = '';

void main() {
}

@observable
String palindrome() {
  var buffer = new StringBuffer(shoutThis);
  for (int i = shoutThis.length - 1; i >= 0; i--) {
    buffer.write(shoutThis[i]);
  }
  return buffer.toString();
}
