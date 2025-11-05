package com.example.a5_11_room;

import androidx.annotation.NonNull;
import androidx.room.EntityDeleteOrUpdateAdapter;
import androidx.room.EntityInsertAdapter;
import androidx.room.RoomDatabase;
import androidx.room.util.DBUtil;
import androidx.room.util.SQLiteStatementUtil;
import androidx.sqlite.SQLiteStatement;
import java.lang.Class;
import java.lang.Override;
import java.lang.String;
import java.lang.SuppressWarnings;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import javax.annotation.processing.Generated;

@Generated("androidx.room.RoomProcessor")
@SuppressWarnings({"unchecked", "deprecation", "removal"})
public final class notesDao_Impl implements notesDao {
  private final RoomDatabase __db;

  private final EntityInsertAdapter<Note> __insertAdapterOfNote;

  private final EntityDeleteOrUpdateAdapter<Note> __deleteAdapterOfNote;

  private final EntityDeleteOrUpdateAdapter<Note> __updateAdapterOfNote;

  public notesDao_Impl(@NonNull final RoomDatabase __db) {
    this.__db = __db;
    this.__insertAdapterOfNote = new EntityInsertAdapter<Note>() {
      @Override
      @NonNull
      protected String createQuery() {
        return "INSERT OR ABORT INTO `Notes` (`id`,`msg`) VALUES (nullif(?, 0),?)";
      }

      @Override
      protected void bind(@NonNull final SQLiteStatement statement, final Note entity) {
        statement.bindLong(1, entity.getId());
        if (entity.getMsg() == null) {
          statement.bindNull(2);
        } else {
          statement.bindText(2, entity.getMsg());
        }
      }
    };
    this.__deleteAdapterOfNote = new EntityDeleteOrUpdateAdapter<Note>() {
      @Override
      @NonNull
      protected String createQuery() {
        return "DELETE FROM `Notes` WHERE `id` = ?";
      }

      @Override
      protected void bind(@NonNull final SQLiteStatement statement, final Note entity) {
        statement.bindLong(1, entity.getId());
      }
    };
    this.__updateAdapterOfNote = new EntityDeleteOrUpdateAdapter<Note>() {
      @Override
      @NonNull
      protected String createQuery() {
        return "UPDATE OR ABORT `Notes` SET `id` = ?,`msg` = ? WHERE `id` = ?";
      }

      @Override
      protected void bind(@NonNull final SQLiteStatement statement, final Note entity) {
        statement.bindLong(1, entity.getId());
        if (entity.getMsg() == null) {
          statement.bindNull(2);
        } else {
          statement.bindText(2, entity.getMsg());
        }
        statement.bindLong(3, entity.getId());
      }
    };
  }

  @Override
  public void addNote(final Note note) {
    DBUtil.performBlocking(__db, false, true, (_connection) -> {
      __insertAdapterOfNote.insert(_connection, note);
      return null;
    });
  }

  @Override
  public void deleteNote(final Note note) {
    DBUtil.performBlocking(__db, false, true, (_connection) -> {
      __deleteAdapterOfNote.handle(_connection, note);
      return null;
    });
  }

  @Override
  public void updateNote(final Note note) {
    DBUtil.performBlocking(__db, false, true, (_connection) -> {
      __updateAdapterOfNote.handle(_connection, note);
      return null;
    });
  }

  @Override
  public List<Note> getNotes() {
    final String _sql = "SELECT * FROM Notes;";
    return DBUtil.performBlocking(__db, true, false, (_connection) -> {
      final SQLiteStatement _stmt = _connection.prepare(_sql);
      try {
        final int _columnIndexOfId = SQLiteStatementUtil.getColumnIndexOrThrow(_stmt, "id");
        final int _columnIndexOfMsg = SQLiteStatementUtil.getColumnIndexOrThrow(_stmt, "msg");
        final List<Note> _result = new ArrayList<Note>();
        while (_stmt.step()) {
          final Note _item;
          final String _tmpMsg;
          if (_stmt.isNull(_columnIndexOfMsg)) {
            _tmpMsg = null;
          } else {
            _tmpMsg = _stmt.getText(_columnIndexOfMsg);
          }
          _item = new Note(_tmpMsg);
          final int _tmpId;
          _tmpId = (int) (_stmt.getLong(_columnIndexOfId));
          _item.setId(_tmpId);
          _result.add(_item);
        }
        return _result;
      } finally {
        _stmt.close();
      }
    });
  }

  @NonNull
  public static List<Class<?>> getRequiredConverters() {
    return Collections.emptyList();
  }
}
