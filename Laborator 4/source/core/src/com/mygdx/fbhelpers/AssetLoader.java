package com.mygdx.fbhelpers;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Preferences;
import com.badlogic.gdx.audio.Music;
import com.badlogic.gdx.audio.Sound;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.Texture.TextureFilter;
import com.badlogic.gdx.graphics.g2d.Animation;
import com.badlogic.gdx.graphics.g2d.BitmapFont;
import com.badlogic.gdx.graphics.g2d.TextureRegion;

public class AssetLoader {
	public static Texture texture;
	public static TextureRegion bg, grass, bird, birdDown, birdUp, barUp, barDown, bar, logo, fbLogo, startButton, ready, gameOver, scoreBoard;
	public static Animation animation;
	public static Sound dead, flap, coin, fall;
	public static BitmapFont font;
	public static Preferences prefs;
	public static Music music;
	public static void load() {
		texture = new Texture(Gdx.files.internal("texture.png"));
		texture.setFilter(TextureFilter.Nearest, TextureFilter.Nearest);
		bg = new TextureRegion(texture, 0, 0, 225, 400);
		bg.flip(false, true);
		
		startButton = new TextureRegion(texture, 562, 196, 62, 35);
		startButton.flip(false, true);
		ready = new TextureRegion(texture, 462, 94, 133, 30);
		ready.flip(false, true);
		gameOver = new TextureRegion(texture, 618, 93, 147, 27);
		gameOver.flip(false, true);
		fbLogo = new TextureRegion(texture, 550, 145, 132, 25);
		fbLogo.flip(false, true);
		
		grass = new TextureRegion(texture, 455, 1, 265, 87);
		grass.flip(false, true);
		
		birdDown = new TextureRegion(texture, 180, 555, 25, 18);
		birdDown.flip(false, true);
		
		bird = new TextureRegion(texture, 180, 514, 25, 18);
		bird.flip(false, true);
		
		birdUp = new TextureRegion(texture, 180, 595, 25, 18);
		birdUp.flip(false, true);
		
		TextureRegion[] birds = {birdDown, bird, birdUp};
		animation = new Animation(0.06f, birds);
		animation.setPlayMode(Animation.PlayMode.LOOP_PINGPONG);
		
		barUp = new TextureRegion(texture, 1, 506, 40, 18);
		barDown = new TextureRegion(barUp);
		barDown.flip(false, true);
		
		bar = new TextureRegion(texture, 1, 535, 40, 3);
		bar.flip(false, true);
		music = Gdx.audio.newMusic(Gdx.files.internal("music.wav"));
		music.setLooping(true);
		music.setVolume(0.1f);
		music.play();
		dead = Gdx.audio.newSound(Gdx.files.internal("fall.mp3"));
		flap = Gdx.audio.newSound(Gdx.files.internal("flap.mp3"));
		coin = Gdx.audio.newSound(Gdx.files.internal("coin.mp3"));
		fall = Gdx.audio.newSound(Gdx.files.internal("fall.mp3"));
		font = new BitmapFont(Gdx.files.internal("text.fnt"));
		font.getData().setScale(0.25f, -0.25f);

		prefs = Gdx.app.getPreferences("FlappyBird");
		if (!prefs.contains("highScore")) {
			prefs.putInteger("highScore", 0);
		}
	}

	public static void dispose() {
		texture.dispose();
		music.dispose();
		dead.dispose();
		flap.dispose();
		coin.dispose();
		fall.dispose();
		font.dispose();
	}

	public static void setHighScore(int score) {
		prefs.putInteger("highScore", score);
		prefs.flush();
	}

	public static int getHighScore() {
		return prefs.getInteger("highScore");
	}
}
