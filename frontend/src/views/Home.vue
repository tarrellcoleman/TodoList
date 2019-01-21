<template>
  <div id="TodoList">
    <form v-on:submit.prevent="submitted()">
      <img alt="Vue logo" src="../assets/logo.png">
      <h1>Todo</h1>
      <input
        v-model= "newTask"
        id ="new-task"
        placeholder="Add Task"
      >
      <input type="image" name="sumbit"
            src="../content/submitButton.png"
            border="0" alt="Submit" style="width: 20px;" />
      <br>
    </form>
    <ul>
      <li v-for="(task, index) in listOfTasks" :key="task.id">
        {{ task.task }}
      <input v-on:click="deleted(index)"
            type="image" name="delete"
            src="../content/deleteButton.png"
            border="0" alt="Delete" style="width: 20px;" />
      <input v-on:click="task.edited=true"
            type="image" name="edit"
            src="../content/editButton.png"
            border="0" alt="Edit" style="width: 20px;" />
      <br>
      <input v-if="task.edited === true"
          v-model= "editedTask"
          id ="edit-task"
          placeholder= "Edit Task">
      <input v-if="task.edited === true"
            v-on:click="edited(index)"
            type="image" name="sumbitEdited"
            src="../content/submitButton.png"
            border="0" alt="Edited" style="width: 20px;" />
      <input v-if="task.edited===true"
            v-on:click="task.edited=false"
            type="image" name="cancel"
            src="../content/cancelButton.png"
            border="0" alt="Cancel" style="width: 20px;" />
      </li>
    </ul>
    </div>
</template>
<script>
// @ is an alias to /src

export default {
  name: 'ToDoList',
  data () {
    return {
      newTask: '',
      listOfTasks: [ ],
      isEdit: false,
      editedTask: ''
    }
  },
  methods: {
    submitted: function () {
      if (this.newTask !== '') {
        this.listOfTasks.push({
          task: this.newTask,
          edited: false
        })
      }
      this.newTask = ''
    },
    deleted: function (index) {
      this.listOfTasks.splice(index, 1)
    },
    edited: function (index) {
      this.$set(this.listOfTasks[index], 'task', this.editedTask)
      this.$set(this.listOfTasks[index], 'edited', false)
      this.editedTask = ''
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
