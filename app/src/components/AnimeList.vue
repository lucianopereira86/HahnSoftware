<script setup>
  import { ref } from 'vue';
  import axios from 'axios';
  import { AgGridVue } from "ag-grid-vue3"; // Vue Data Grid Component
  import { AllCommunityModule, ModuleRegistry } from 'ag-grid-community';

  // Register all Community features
  ModuleRegistry.registerModules([AllCommunityModule]);

  // Row Data: The data to be displayed.
  const rowData = ref([]);

  // Column Definitions: Defines the columns to be displayed.
  const colDefs = ref([
    { headerName: "Id", field: "id", filter: true, width: 100 },
    { headerName: "Anime Id", field: "animeId", filter: true, width: 150 },
    { headerName: "Title", field: "title", filter: true },
    { headerName: "Poster Image", field: "posterImage", filter: true },
    { headerName: "Slug", field: "slug", filter: true },
    { headerName: "Synopsis", field: "synopsis", filter: true },
    { headerName: "Canonical Title", field: "canonicalTitle", filter: true },
    { headerName: "Abbreviated Titles", field: "abbreviatedTitles", filter: true },
    { headerName: "Average Rating", field: "averageRating", filter: true },
    { headerName: "User Count", field: "userCount", filter: true },
    { headerName: "Favorites Count", field: "favoritesCount", filter: true },
    { headerName: "Start Date", field: "startDate", filter: true },
    { headerName: "End Date", field: "endDate", filter: true },
    { headerName: "Popularity Rank", field: "popularityRank", filter: true },
    { headerName: "Rating Rank", field: "ratingRank", filter: true },
    { headerName: "Age Rating Guide", field: "ageRatingGuide", filter: true },
    { headerName: "Episode Count", field: "episodeCount", filter: true },
    { headerName: "Episode Length", field: "episodeLength", filter: true },
    { headerName: "NSFW", field: "nsfw", filter: true }
  ]);

  const loading = ref(false)

  function loadAnimes() {
    loading.value = true;
    rowData.value = [];
    axios.get('http://localhost:5009/anime')
      .then(response => {
        console.log(response.data);
        response.data.$values.forEach((anime) => {
          rowData.value.push({
            id: anime.id,
            animeId: anime.animeId,
            title: anime.title.en,
            posterImage: anime.posterImage.small,
            slug: anime.slug,
            synopsis: anime.synopsis,
            canonicalTitle: anime.canonicalTitle,
            abbreviatedTitles: anime.abbreviatedTitles,
            averageRating: anime.averageRating,
            userCount: anime.userCount,
            favoritesCount: anime.favoritesCount,
            startDate: anime.startDate.split('T')[0],
            endDate: anime.endDate.split('T')[0],
            popularityRank: anime.popularityRank,
            ratingRank: anime.ratingRank,
            ageRatingGuide: anime.ageRatingGuide,
            episodeCount: anime.episodeCount,
            episodeLength: anime.episodeLength,
            nsfw: anime.nsfw
          });
        });
        console.log(rowData);
      })
      .catch(error => {
        console.log(error);
      })
      .finally(() => {
        loading.value = false;
      });
  }
</script>

<template>
  <div class="container">
    <div class="btnContainer">
      <span v-if="loading">Searching...</span>
      <button v-else @click="loadAnimes">Search For Animes</button>
    </div>
    <!-- The AG Grid component -->
    <ag-grid-vue :rowData="rowData"
                 :columnDefs="colDefs"
                 style="height: 500px">
    </ag-grid-vue>
  </div>
</template>

<style>
  .container {
    align-items: center;
    text-align: center;
    gap: 40px;
  }
  .btnContainer{
    margin: 20px 0 20px 0;
  }
</style>
