import 'dart:html';

InputElement toDoInput;
UListElement toDoList;
ButtonElement deleteAll;

void main() {
  toDoInput = query('#to-do-input');
  toDoList = query('#to-do-list');
  toDoInput.onChange.listen(addToDoItem);
  deleteAll = query('#delete-all');
  deleteAll.onClick.listen((e) => toDoList.children.clear());   // 清除节点下所有子节点
}

void addToDoItem(Event e){
  var newToDo = new LIElement();
  newToDo.text = toDoInput.value;
  newToDo.onClick.listen((e) => newToDo.remove());  // 删除当前节点
  toDoInput.value = '';
  toDoList.children.add(newToDo);
}

