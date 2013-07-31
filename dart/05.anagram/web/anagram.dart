import 'dart:html';
import 'dart:math';

String scrabbleLetters = 'aaaaaaaaabbccddddeeeeeeeeeeeeffggghhiiiiiiiiijkllllmmnnnnnnooooooooppqrrrrrrssssttttttuuuuvvwwxyyz**';

List<ButtonElement> buttons = new List();   // 字母按钮
Element letterpile;                         // 字母堆
Element result;                             // 结果
ButtonElement clearButton;                  // 清空按钮
Element value;                              // 字母值
int wordvalue = 0;                          // 字母值

Map scrabbleValues = { 'a':1, 'e':1, 'i':1, 'l':1, 'n':1,
                       'o':1, 'r':1, 's':1, 't':1, 'u':1,
                       'd':2, 'g':2, 'b':3, 'c':3, 'm':3,
                       'p':3, 'f':4, 'h':4, 'v':4, 'w':4,
                       'y':4, 'k':5, 'j':8, 'x':8, 'q':10,
                       'z':10, '*':0 };

void main() {
  letterpile = query("#letterpile");
  result = query("#result");
  value = query("#value");
  
  clearButton = query("#clearButton");
  clearButton.onClick.listen(newletters);
  
  generateNewLetters();
}

/**
 * 移动字母
 */
void moveLetter(Event e) {
  Element letter = e.target;
  if (letter.parent == letterpile) {
    result.children.add(letter);
    wordvalue += scrabbleValues[letter.text];
    value.text = "$wordvalue";
  } else {
    letterpile.children.add(letter);
    wordvalue -= scrabbleValues[letter.text];
    value.text = "$wordvalue";
  }
}

/**
 * 清空，重新生成字母
 */
void newletters(Event e) {
  letterpile.children.clear();
  result.children.clear();
  generateNewLetters();
}

/**
 * 生成字母
 */
generateNewLetters() {
  Random indexGenerator = new Random();
  wordvalue = 0;
  value.text = '';
  buttons.clear();
  for (var i = 0; i < 7; i++) {
    int letterIndex = indexGenerator.nextInt(scrabbleLetters.length);
    buttons.add(new ButtonElement());
    buttons[i].classes.add("letter");
    buttons[i].onClick.listen(moveLetter);
    buttons[i].text = scrabbleLetters[letterIndex];
    letterpile.children.add(buttons[i]);
  }
}