import 'package:built_value/built_value.dart';
part 'app_state.g.dart';

abstract class AppState implements Built<AppState, AppStateBuilder> {
  AppState._();
  factory AppState([updates(AppStateBuilder b)]) = _$AppState;

// Modules States

  /// Create a new empty App state
  factory AppState.initialState() => AppState(
        (a) => a..authState.replace(AuthState()),
      );

  /// Hydrate a State from the cache
  factory AppState.fromCache({AuthState authState}) => AppState(
        (a) => a..authState.replace(authState ?? AuthState()),
      );

  /// Reset all the app state
  AppState clear() {
    // Add here anything else that also needs to be carried over.
    return AppState.initialState().rebuild();
  }
}
