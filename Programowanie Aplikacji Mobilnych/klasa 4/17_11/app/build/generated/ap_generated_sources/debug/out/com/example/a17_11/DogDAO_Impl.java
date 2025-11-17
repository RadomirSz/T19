package com.example.a17_11;

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
public final class DogDAO_Impl implements DogDAO {
  private final RoomDatabase __db;

  private final EntityInsertAdapter<DogResponse> __insertAdapterOfDogResponse;

  private final EntityDeleteOrUpdateAdapter<DogResponse> __deleteAdapterOfDogResponse;

  public DogDAO_Impl(@NonNull final RoomDatabase __db) {
    this.__db = __db;
    this.__insertAdapterOfDogResponse = new EntityInsertAdapter<DogResponse>() {
      @Override
      @NonNull
      protected String createQuery() {
        return "INSERT OR ABORT INTO `dogs` (`Id`,`message`,`status`) VALUES (nullif(?, 0),?,?)";
      }

      @Override
      protected void bind(@NonNull final SQLiteStatement statement, final DogResponse entity) {
        statement.bindLong(1, entity.getId());
        if (entity.getMessage() == null) {
          statement.bindNull(2);
        } else {
          statement.bindText(2, entity.getMessage());
        }
        if (entity.getStatus() == null) {
          statement.bindNull(3);
        } else {
          statement.bindText(3, entity.getStatus());
        }
      }
    };
    this.__deleteAdapterOfDogResponse = new EntityDeleteOrUpdateAdapter<DogResponse>() {
      @Override
      @NonNull
      protected String createQuery() {
        return "DELETE FROM `dogs` WHERE `Id` = ?";
      }

      @Override
      protected void bind(@NonNull final SQLiteStatement statement, final DogResponse entity) {
        statement.bindLong(1, entity.getId());
      }
    };
  }

  @Override
  public void insertDog(final DogResponse dogResponse) {
    DBUtil.performBlocking(__db, false, true, (_connection) -> {
      __insertAdapterOfDogResponse.insert(_connection, dogResponse);
      return null;
    });
  }

  @Override
  public void deleteDog(final DogResponse dogResponse) {
    DBUtil.performBlocking(__db, false, true, (_connection) -> {
      __deleteAdapterOfDogResponse.handle(_connection, dogResponse);
      return null;
    });
  }

  @Override
  public List<DogResponse> getAllDogs() {
    final String _sql = "SELECT * FROM dogs;";
    return DBUtil.performBlocking(__db, true, false, (_connection) -> {
      final SQLiteStatement _stmt = _connection.prepare(_sql);
      try {
        final int _columnIndexOfId = SQLiteStatementUtil.getColumnIndexOrThrow(_stmt, "Id");
        final int _columnIndexOfMessage = SQLiteStatementUtil.getColumnIndexOrThrow(_stmt, "message");
        final int _columnIndexOfStatus = SQLiteStatementUtil.getColumnIndexOrThrow(_stmt, "status");
        final List<DogResponse> _result = new ArrayList<DogResponse>();
        while (_stmt.step()) {
          final DogResponse _item;
          _item = new DogResponse();
          final int _tmpId;
          _tmpId = (int) (_stmt.getLong(_columnIndexOfId));
          _item.setId(_tmpId);
          final String _tmpMessage;
          if (_stmt.isNull(_columnIndexOfMessage)) {
            _tmpMessage = null;
          } else {
            _tmpMessage = _stmt.getText(_columnIndexOfMessage);
          }
          _item.setMessage(_tmpMessage);
          final String _tmpStatus;
          if (_stmt.isNull(_columnIndexOfStatus)) {
            _tmpStatus = null;
          } else {
            _tmpStatus = _stmt.getText(_columnIndexOfStatus);
          }
          _item.setStatus(_tmpStatus);
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
