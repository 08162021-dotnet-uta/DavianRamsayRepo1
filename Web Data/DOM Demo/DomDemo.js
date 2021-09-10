"Use Strict"
console.log('Hey there');

//get a referenceto the add todo form
const addtodoform = document.querySelector('.addtodo');
const todolist = document.querySelector('.todolist');
const searchterm = document.querySelector('.searchterm');

//add an event listener
addtodoform.addEventListener('submit', (e) => {
  e.preventDefault() //stops refreshing the page
  e.stopPropagation(); //stop the bubling of the event up the chain...see docs pdf
  console.log(e) //print the event itself 

  //print the value inputted
  //console.log(`The value inputted is => ${addtodoform.addtodos.value}`);

  //grab the value and trimthe excess whitespace
  const todo1 = addtodoform.addtodos.value.trim();
  todolist.innerHTML += `<p class ="todoitem">${todo1}</p>`

  //rest the form to remove the values inputed in a paragraph tag above
  addtodoform.reset();

});

//adding an event to remove the values added to the list to be deleted by the click of the mouse on that specific item
todolist.addEventListener('click', (e) => {
  e.stopPropagation();
  console.log(e);
  e.target.remove();
});


//implement searching by the term user has entered 
searchterm.addEventListener('keyup', (e) => {
  const term = searchterm.value.trim();

  //getting all the children of (<p>) and putting them in an array
  const todosarray = Array.from(todolist.children);

  //filter the array to add a class to the element that do not contain the search term
  todosarray.filter((todo) => {
    return !todo.textContent.includes(term);
  })
    .forEach((todo) => todo.classList.add('hidethis'));

  todosarray.filter((todo) => {
    return todo.textContent.includes(term);
  })
    .forEach((todo) => todo.classList.remove('hidethis'));


});