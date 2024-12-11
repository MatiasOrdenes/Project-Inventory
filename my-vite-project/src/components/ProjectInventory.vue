<template>
  <div class="p-8 bg-gray-50 min-h-screen">
    <h1 class="text-3xl font-bold text-gray-800 mb-8 text-center">Project Inventory</h1>
    <form @submit.prevent="addItem" class="space-y-6 p-6 bg-white rounded-lg shadow-md sm:w-full md:w-2/3 lg:w-1/2 mx-auto">
      <div>
        <label for="name" class="block text-sm font-medium text-gray-700">Item Name</label>
        <input
          id="name"
          v-model="newItem.name"
          class="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:ring-blue-500 focus:border-blue-500"
        />
      </div>
      <div>
        <label for="quantity" class="block text-sm font-medium text-gray-700">Quantity</label>
        <input
          id="quantity"
          v-model="newItem.quantity"
          type="number"
          class="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:ring-blue-500 focus:border-blue-500"
        />
      </div>
      <div>
        <label for="description" class="block text-sm font-medium text-gray-700">Description</label>
        <textarea
          id="description"
          v-model="newItem.description"
          class="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:ring-blue-500 focus:border-blue-500"
        ></textarea>
      </div>
      <button type="submit" class="w-full py-2 px-4 bg-blue-500 text-white rounded-md shadow-md hover:bg-blue-600">
        Add Item
      </button>
    </form>
    <ul class="mt-10 space-y-4">
      <li v-for="item in items" :key="item.id" class="p-6 bg-white rounded-lg shadow-md flex justify-between items-center">
        <div>
          <p class="text-lg font-semibold text-gray-900">{{ item.name }} ({{ item.quantity }})</p>
          <p class="text-sm text-gray-500">{{ item.description }}</p>
        </div>
        <div>
          <button @click="editItem(item)" class="mr-2 px-4 py-2 bg-yellow-400 text-white rounded-md shadow-md hover:bg-yellow-500">
            Edit
          </button>
          <button @click="deleteItem(item.id)" class="px-4 py-2 bg-red-500 text-white rounded-md shadow-md hover:bg-red-600">
            Delete
          </button>
        </div>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "ProjectInventory",
  data() {
    return {
      items: [], // Ensure this is an array
      newItem: { name: "", quantity: 0, description: "" },
    };
  },
  methods: {
    addItem() {
      if (!this.newItem.name || this.newItem.quantity <= 0) {
        alert("Please provide valid inputs");
        return;
      }
      // Temporary mock logic (replace with API call)
      const newItem = { ...this.newItem, id: Date.now() };
      this.items.push(newItem);
      this.newItem = { name: "", quantity: 0, description: "" };
    },
    editItem(item) {
      this.newItem = { ...item };
    },
    deleteItem(id) {
      this.items = this.items.filter((item) => item.id !== id);
    },
  },
};
</script>

<style scoped>
/* Add custom styles if needed */
</style>
