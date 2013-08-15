Todos.TodosController = Ember.ArrayController.extend({
    createTodo: function () {
        // 通过“newTitle”获取 todo 标题
        var title = this.get('newTitle');
        if (!title.trim()) { return; }

        // 新建 todo
        var todo = Todos.Todo.createRecord({
            title: title,
            isCompleted: false
        });

        // 清空“newTitle”的文本
        this.set('newTitle', '');

        // 保存新 todo
        todo.save();
    }
});
