(function() {

function DisplayComponent() {
  this.myName = "Alice";
  this.names = ["Aarav", "Martín", "Shannon", "Ariana", "Kai"];
}

DisplayComponent.annotations = [
  new angular.ComponentAnnotation({
    selector: "display"
  }),
  new angular.ViewAnnotation({
    template:
      '<p>My name: {{ myName }}</p>' +
      '<p>Firends:</p>' +
      '<ul>' +
      '<li *ng-for="#name of names">' +
      '{{ name }}' +
      '</li>' +
      '</ul>',
    directives: [angular.NgFor]
  })
];


document.addEventListener('DOMContentLoaded', function() {
  ng.bootstrap(DisplayComponent);
});

})();
