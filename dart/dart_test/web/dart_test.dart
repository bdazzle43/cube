import 'dart:html';
import 'package:markdown/markdown.dart' show markdownToHtml;


void main() {
  print(markdownToHtml('Hello *Markdown*'));
}

