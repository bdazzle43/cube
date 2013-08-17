Todos.TodoController = Ember.ObjectController.extend({
    isCompleted: function(key, value) {
        var model = this.get('model');

        if (value === undefined) {
            // 属性被当作 getter 使用
            return model.get('isCompleted');
        } else {
            // 属性被当作 setter 使用
            model.set('isCompleted', value);
            model.save();
            return value;
        }
    }.property('model.isCompleted')
});
