package com.example.a5_11_room;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import java.util.List;

@Dao
public interface notesDao {
    @Insert
    void addNote(Note note);
    @Query("SELECT * FROM Notes;")
    List<Note> getNotes();
    @Update
    void updateNote(Note note);
    @Delete
    void deleteNote(Note note);
}
