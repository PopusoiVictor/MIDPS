package com.mygdx.flappybird;

import com.badlogic.gdx.Game;
import com.mygdx.fbhelpers.AssetLoader;
import com.mygdx.button.screens.GameScreen;

public class FBGame extends Game {

	@Override
	public void create() {
		AssetLoader.load();
		setScreen(new GameScreen());
	}

	@Override
	public void dispose() {
		super.dispose();
		AssetLoader.dispose();
	}
	
}
