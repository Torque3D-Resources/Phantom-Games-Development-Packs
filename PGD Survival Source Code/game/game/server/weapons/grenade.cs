//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

$GrenadeUpVectorOffset = "0 0 1";



//----------------------------------------------------------------------------
// Sounds
//----------------------------------------------------------------------------

datablock SFXProfile(GrenadeExplosionSound)
{
   filename = "art/sound/CT_fx/weapons/GRENADELAND.wav";
   description = AudioDefault3d;
   preload = true;
};

// ----------------------------------------------------------------------------
// Explosion Particle effects
// ----------------------------------------------------------------------------

datablock ParticleData(GrenadeExpFire)
{
   textureName = "art/shapes/particles/fireball.png";
   dragCoeffiecient = 0;
   windCoeffiecient = 0.5;
   gravityCoefficient = -1;
   inheritedVelFactor = 0;
   constantAcceleration = 0;
   lifetimeMS = 1200;//3000;
   lifetimeVarianceMS = 100;//200;
   useInvAlpha = false;
   spinRandomMin = 0;
   spinRandomMax = 1;
   spinSpeed = 1;
   colors[0] = "0.886275 0.854902 0.733333 0.795276";
   colors[1] = "0.356863 0.34902 0.321569 0.266";
   colors[2] = "0.0235294 0.0235294 0.0235294 0.207";
   sizes[0] = 1;//2;
   sizes[1] = 5;
   sizes[2] = 7;//0.5;
   times[0] = 0.0;
   times[1] = 0.25;
   times[2] = 0.5;
   animTexName = "art/shapes/particles/fireball.png";
   times[3] = "1";
   dragCoefficient = "1.99902";
   sizes[3] = "10";
   colors[3] = "0 0 0 0";
};

datablock ParticleEmitterData(GrenadeExpFireEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;//0;
   ejectionVelocity = 1;//1.0;
   velocityVariance = 0;//0.5;
   thetaMin = 0.0;
   thetaMax = 45;
   lifetimeMS = 250;
   particles = "GrenadeExpFire";
   blendStyle = "ADDITIVE";
};

datablock ParticleData(GrenadeExpDust)
{
   textureName = "art/shapes/particles/smoke.png";
   dragCoefficient = 0.498534;
   gravityCoefficient = 0;
   inheritedVelFactor = 1;
   constantAcceleration = 0.0;
   lifetimeMS = 2000;
   lifetimeVarianceMS = 250;
   useInvAlpha = 0;
   spinSpeed = 1;
   spinRandomMin = -90.0;
   spinRandomMax = 90.0;
   colors[0] = "0.992126 0.992126 0.992126 0.96063";
   colors[1] = "0.11811 0.11811 0.11811 0.929134";
   colors[2] = "0.00392157 0.00392157 0.00392157 0.362205";
   sizes[0] = 1.59922;
   sizes[1] = 4.99603;
   sizes[2] = 9.99817;
   times[0] = 0.0;
   times[1] = 0.494118;
   times[2] = 1.0;
   animTexName = "art/shapes/particles/smoke.png";
   colors[3] = "0.996078 0.996078 0.996078 0";
   sizes[3] = "15";
};

datablock ParticleEmitterData(GrenadeExpDustEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 8;
   velocityVariance = 0.0;
   ejectionOffset = 0.0;
   thetaMin = 85;
   thetaMax = 85;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvances = 0;
   lifetimeMS = 2000;
   particles = "GrenadeExpDust";
   blendStyle = "NORMAL";
};

datablock ParticleData(GrenadeExpSpark)
{
   textureName = "art/shapes/particles/Sparkparticle";
   dragCoefficient = 1;
   gravityCoefficient = 0.0;
   inheritedVelFactor = 0.2;
   constantAcceleration = 0.0;
   lifetimeMS = 500;
   lifetimeVarianceMS = 250;
   colors[0] = "0.6 0.4 0.3 1";
   colors[1] = "0.6 0.4 0.3 1";
   colors[2] = "1.0 0.4 0.3 0";
   sizes[0] = 0.5;
   sizes[1] = 0.75;
   sizes[2] = 1;
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
};

datablock ParticleEmitterData(GrenadeExpSparkEmitter)
{
   ejectionPeriodMS = 2;
   periodVarianceMS = 0;
   ejectionVelocity = 20;
   velocityVariance = 10;
   ejectionOffset = 0.0;
   thetaMin = 0;
   thetaMax = 120;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvances = false;
   orientParticles = true;
   lifetimeMS = 100;
   particles = "GrenadeExpSpark";
};

datablock ParticleData(GrenadeExpSparks)
{
   textureName = "art/shapes/particles/droplet";
   dragCoefficient = 1;
   gravityCoefficient = 0.0;
   inheritedVelFactor = 0.2;
   constantAcceleration = 0.0;
   lifetimeMS = 500;
   lifetimeVarianceMS = 350;

   colors[0] = "0.6 0.4 0.3 1.0";
   colors[1] = "0.6 0.4 0.3 0.6";
   colors[2] = "1.0 0.4 0.3 0.0";

   sizes[0] = 0.5;
   sizes[1] = 0.5;
   sizes[2] = 0.75;

   times[0] = 0.0;
   times[1] = 0.5;
   times[2] = 1.0;
};

datablock ParticleEmitterData(GrenadeExpSparksEmitter)
{
   ejectionPeriodMS = 2;
   periodVarianceMS = 0;
   ejectionVelocity = 12;
   velocityVariance = 6.75;
   ejectionOffset = 0.0;
   thetaMin = 0;
   thetaMax = 60;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvances = false;
   orientParticles = true;
   lifetimeMS = 100;
   particles = "GrenadeExpSparks";
};

datablock ParticleData(GrenadeExpSmoke)
{
   textureName = "art/shapes/particles/smoke";
   dragCoeffiecient = 0;
   gravityCoefficient = -0.40293;
   inheritedVelFactor = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS = 800;
   lifetimeVarianceMS = 299;
   useInvAlpha = true;
   spinSpeed = 1;
   spinRandomMin = -80.0;
   spinRandomMax = 0;
   colors[0] = "0.8 0.8 0.8 0.4";
   colors[1] = "0.5 0.5 0.5 0.5";
   colors[2] = "0.75 0.75 0.75 0";
   sizes[0] = 4.49857;
   sizes[1] = 7.49863;
   sizes[2] = 11.2495;
   times[0] = 0;
   times[1] = 0.498039;
   times[2] = 1;
   animTexName = "art/shapes/particles/smoke";
   times[3] = "1";
};

datablock ParticleEmitterData(GrenadeExpSmokeEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;
   ejectionVelocity = 2.4;
   velocityVariance = 1.2;
   thetaMin = 0.0;
   thetaMax = 180.0;
   ejectionOffset = 1;
   particles = "GrenadeExpSmoke";
   blendStyle = "NORMAL";
};


// ----------------------------------------------------------------------------
// Dry/Air Explosion Objects
// ----------------------------------------------------------------------------

datablock ExplosionData(GrenadeExplosion)
{
   soundProfile = GrenadeExplosionSound;
   lifeTimeMS = 400; // Quick flash, short burn, and moderate dispersal

   // Volume particles
   particleEmitter = GrenadeExpFireEmitter;
   particleDensity = 75;
   particleRadius = 2.25;

   // Point emission
   emitter[0] = GrenadeExpDustEmitter;
   emitter[1] = GrenadeExpSparksEmitter;
   emitter[2] = GrenadeExpSmokeEmitter;

   // Camera Shaking
   shakeCamera = true;
   camShakeFreq = "10.0 11.0 9.0";
   camShakeAmp = "15.0 15.0 15.0";
   camShakeDuration = 1.5;
   camShakeRadius = 20;

   lightStartRadius = 4.0;
   lightEndRadius = 0.0;
   lightStartColor = "1.0 1.0 1.0";
   lightEndColor = "1.0 1.0 1.0";
   lightStartBrightness = 4.0;
   lightEndBrightness = 0.0;
   lightNormalOffset = 2.0;
};

datablock ExplosionData(DukeShockwaveExplosion) {
   soundProfile = GrenadeExplosionSound;
   lifeTimeMS = 400; // Quick flash, short burn, and moderate dispersal

   // Volume particles
   particleEmitter = GrenadeExpFireEmitter;
   particleDensity = 35;
   particleRadius = 2.25;

   // Point emission
   emitter[0] = GrenadeExpDustEmitter;
   emitter[1] = GrenadeExpSparksEmitter;

   // Camera Shaking
   shakeCamera = true;
   camShakeFreq = "4.0 5.0 4.0";
   camShakeAmp = "15.0 15.0 15.0";
   camShakeDuration = 1.5;
   camShakeRadius = 10;

   lightStartRadius = 4.0;
   lightEndRadius = 0.0;
   lightStartColor = "1.0 1.0 1.0";
   lightEndColor = "1.0 1.0 1.0";
   lightStartBrightness = 4.0;
   lightEndBrightness = 0.0;
   lightNormalOffset = 2.0;
};