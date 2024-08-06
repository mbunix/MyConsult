import 'package:built_value/built_value.dart';
part 'app_state.g.dart';

abstract class AppState implements Built<AppState, AppStateBuilder> {
  AppState._();
}
