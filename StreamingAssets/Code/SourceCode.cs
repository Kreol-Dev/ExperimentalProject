namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									UnityEngine.Vector3 OperandVar15 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar11 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop10 = External.Random( (0f), (100f)); //IsContext = False IsNew = False
									OperandVar11 = prop10;
									System.Single OperandVar13 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop12 = External.Random( (0f), (100f)); //IsContext = False IsNew = False
									OperandVar13 = prop12;
									UnityEngine.Vector3 prop14 = External.Vec( (OperandVar11), (OperandVar13)); //IsContext = False IsNew = False
									OperandVar15 = prop14;
									AddContext9.Position = (UnityEngine.Vector3)( (OperandVar15));
								}
							}
							Place AddContext16 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext16 ContextSwitchInterpreter
								if(AddContext16 != null)
								{
									System.Single OperandVar18 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop17 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar18 = prop17;
									AddContext16.Size = (System.Int32)( (OperandVar18));
								}
							}
							Markers AddContext19 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							Named AddContext20 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext20 ContextSwitchInterpreter
								if(AddContext20 != null)
								{
									
									
									
									AddContext20.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar23 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar21 = default(System.String); //IsContext = False IsNew = False
									OperandVar21 = "human_name";
									System.String prop22 = External.RandomName( (OperandVar21)); //IsContext = False IsNew = False
									if(prop22 != null)
									{
										OperandVar23 = prop22;
									}
									AddContext20.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar23)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						
						{
							UnityEngine.GameObject subContext24 = loc; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.GameObject subContext24 ContextPropertySwitchInterpreter
							if(subContext24 != null)
							{
								
								{
									Markers subContext25 = (Markers)subContext24.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
									//ContextStatement Markers subContext25 ContextSwitchInterpreter
									if(subContext25 != null)
									{
										System.String OperandVar26 = default(System.String); //IsContext = False IsNew = False
										OperandVar26 = "history_place";
										subContext25.SetMarker(( (OperandVar26)).ToString());
									}
								}
							}
						}
						Place OperandVar28 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable27 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable27 != null)
						{
							OperandVar28 = StoredVariable27;
						}
						subContext5.Attach((Place)( (OperandVar28)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar42 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable29 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable29 != null)
			{
				Markers StoredVariable30 = ((Markers)StoredVariable29.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable30 != null)
				{
					System.Boolean ifResult31; //IsContext = False IsNew = False
					
					System.Boolean OperandVar38 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable29 != null)
					{
						UnityEngine.GameObject prop32 = StoredVariable29.ShowedObject; //IsContext = False IsNew = False
						if(prop32 != null)
						{
							System.Boolean ifResult33; //IsContext = False IsNew = False
							System.Boolean OperandVar37 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar35 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable34 = ((Named)prop32.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable34 != null)
							{
								OperandVar35 = StoredVariable34;
							}
							System.Boolean prop36 = External.Has( (OperandVar35)); //IsContext = False IsNew = False
							OperandVar37 = prop36;
							if(ifResult33 =  (OperandVar37))
							{
								OperandVar38 = ifResult33;
							}
						}
					}
					
					System.Boolean OperandVar41 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar39 = default(System.String); //IsContext = False IsNew = False
					OperandVar39 = "named_ui_marker";
					System.Boolean prop40 = StoredVariable30.HasMarker( (OperandVar39)); //IsContext = False IsNew = False
					OperandVar41 = prop40;
					if(ifResult31 = ( ( (OperandVar38))) && ( (!(OperandVar41))))
					{
						applicable = true;
						OperandVar42 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar42);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext43 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext43 ContextSwitchInterpreter
				if(subContext43 != null)
				{
					System.String OperandVar44 = default(System.String); //IsContext = False IsNew = False
					OperandVar44 = "named_ui_marker";
					subContext43.SetUiMarker(( (OperandVar44)).ToString());
				}
			}
			
			{
				UiObject subContext45 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext45 ContextSwitchInterpreter
				if(subContext45 != null)
				{
					Named OperandVar48 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop46 = subContext45.ShowedObject; //IsContext = False IsNew = False
					if(prop46 != null)
					{
						Named StoredVariable47 = ((Named)prop46.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable47 != null)
						{
							OperandVar48 = StoredVariable47;
						}
					}
					Named showed_named =  (OperandVar48); //IsContext = False IsNew = False
					TextField ContextVar49 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar49 ContextSwitchInterpreter
						if(ContextVar49 != null)
						{
							System.String OperandVar51 = default(System.String); //IsContext = False IsNew = False
							System.String prop50 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop50 != null)
							{
								OperandVar51 = prop50;
							}
							ContextVar49.Show(( (OperandVar51)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda52 = () => 
									{
										System.String OperandVar54 = default(System.String); //IsContext = False IsNew = False
										System.String prop53 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop53 != null)
										{
											OperandVar54 = prop53;
										}
										ContextVar49.Show(( (OperandVar54)).ToString());
									};
									showed_named.OnUpdate(Lambda52);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext55 = ContextVar49.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext55 ContextPropertySwitchInterpreter
								if(subContext55 != null)
								{
									
									subContext55.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar56 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar56 != null) EntVar56.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar70 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable57 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable57 != null)
			{
				UiObject StoredVariable58 = ((UiObject)StoredVariable57.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable58 != null)
				{
					System.Boolean ifResult59; //IsContext = False IsNew = False
					
					System.Boolean OperandVar66 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop60 = StoredVariable58.ShowedObject; //IsContext = False IsNew = False
					if(prop60 != null)
					{
						System.Boolean ifResult61; //IsContext = False IsNew = False
						System.Boolean OperandVar65 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar63 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable62 = ((Place)prop60.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable62 != null)
						{
							OperandVar63 = StoredVariable62;
						}
						System.Boolean prop64 = External.Has( (OperandVar63)); //IsContext = False IsNew = False
						OperandVar65 = prop64;
						if(ifResult61 =  (OperandVar65))
						{
							OperandVar66 = ifResult61;
						}
					}
					
					System.Boolean OperandVar69 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar67 = default(System.String); //IsContext = False IsNew = False
					OperandVar67 = "place_ui_set";
					System.Boolean prop68 = StoredVariable57.HasMarker( (OperandVar67)); //IsContext = False IsNew = False
					OperandVar69 = prop68;
					if(ifResult59 = ( ( (OperandVar66))) && ( (!(OperandVar69))))
					{
						applicable = true;
						OperandVar70 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar70);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext71 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext71 ContextSwitchInterpreter
				if(subContext71 != null)
				{
					System.String OperandVar72 = default(System.String); //IsContext = False IsNew = False
					OperandVar72 = "place_ui_set";
					subContext71.SetUiMarker(( (OperandVar72)).ToString());
				}
			}
			
			{
				UiObject subContext73 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext73 ContextSwitchInterpreter
				if(subContext73 != null)
				{
					Place OperandVar76 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop74 = subContext73.ShowedObject; //IsContext = False IsNew = False
					if(prop74 != null)
					{
						Place StoredVariable75 = ((Place)prop74.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable75 != null)
						{
							OperandVar76 = StoredVariable75;
						}
					}
					Place pl =  (OperandVar76); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar77 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar79 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop78 = pl.Size; //IsContext = False IsNew = False
							OperandVar79 = prop78;
							puidata.LastSize = (System.Int32)( (OperandVar79));
						}
					}
					TextField ContextVar80 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar80 ContextSwitchInterpreter
						if(ContextVar80 != null)
						{
							System.Int32 OperandVar82 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop81 = pl.Size; //IsContext = False IsNew = False
							OperandVar82 = prop81;
							ContextVar80.Show(( (OperandVar82)).ToString());
							System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar84 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable83 = ((Updated)ContextVar80.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable83 != null)
							{
								OperandVar84 = StoredVariable83;
							}
							System.Boolean prop85 = External.Has( (OperandVar84)); //IsContext = False IsNew = False
							OperandVar86 = prop85;
							if(!(OperandVar86))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar80 ContextSwitchInterpreter
								if(ContextVar80 != null)
								{
									
									ContextVar80.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext87 = ContextVar80.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext87 ContextPropertySwitchInterpreter
								if(subContext87 != null)
								{
									
									subContext87.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext88 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext88 ContextSwitchInterpreter
								if(subContext88 != null)
								{
									BoolDelegate Lambda89 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar91 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop90 = pl.Size; //IsContext = False IsNew = False
															OperandVar91 = prop90;
														}
														
														System.Int32 OperandVar93 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop92 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar93 = prop92;
														}
														if(!(( ( (OperandVar91))) == ( ( (OperandVar93)))))
														{
															System.Int32 OperandVar95 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop94 = pl.Size; //IsContext = False IsNew = False
																OperandVar95 = prop94;
															}
															puidata.LastSize = (System.Int32)( (OperandVar95));
															System.Int32 OperandVar97 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop96 = pl.Size; //IsContext = False IsNew = False
																OperandVar97 = prop96;
															}
															ContextVar80.Show(( (OperandVar97)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext88.OnUpdate(Lambda89);
								}
							}
						}
					}
					if(EntVar77 != null) EntVar77.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar106 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable98 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable98 != null)
			{
				Place StoredVariable99 = ((Place)StoredVariable98.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable99 != null)
				{
					System.Boolean ifResult100; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar102 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop101 = StoredVariable99.Agents; //IsContext = False IsNew = False
					if(prop101 != null)
					{
						OperandVar102 = prop101;
					}
					
					
					
					System.Boolean OperandVar105 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar103 = default(System.String); //IsContext = False IsNew = False
					OperandVar103 = "agents_pool";
					System.Boolean prop104 = StoredVariable98.HasMarker( (OperandVar103)); //IsContext = False IsNew = False
					OperandVar105 = prop104;
					if(ifResult100 = ( (( ( (OperandVar102 != null ? OperandVar102.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar105))))
					{
						applicable = true;
						OperandVar106 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar106);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext107 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext107 ContextSwitchInterpreter
				if(subContext107 != null)
				{
					
					subContext107.Size = (System.Int32)( (5f));
					System.Single OperandVar109 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop108 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar109 = prop108;
					for (int i = 0; i <  (OperandVar109); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag110 = ag; //IsContext = True IsNew = False
							Entity AddContext111 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext112 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext113 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext113 ContextSwitchInterpreter
								if(AddContext113 != null)
								{
									System.Single OperandVar115 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop114 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar115 = prop114;
									AddContext113.Age = (System.Int32)( (OperandVar115));
								}
							}
							Named AddContext116 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext116 ContextSwitchInterpreter
								if(AddContext116 != null)
								{
									
									
									
									AddContext116.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar119 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar117 = default(System.String); //IsContext = False IsNew = False
									OperandVar117 = "human_name";
									System.String prop118 = External.RandomName( (OperandVar117)); //IsContext = False IsNew = False
									if(prop118 != null)
									{
										OperandVar119 = prop118;
									}
									AddContext116.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar119)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar121 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable120 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable120 != null)
						{
							OperandVar121 = StoredVariable120;
						}
						subContext107.Attach((Agent)( (OperandVar121)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable122 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable122 != null)
			{
				System.Boolean ifResult123; //IsContext = False IsNew = False
				System.Boolean OperandVar127 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar125 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable124 = ((Blackboards.event_marker)StoredVariable122.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable124 != null)
				{
					OperandVar125 = StoredVariable124;
				}
				System.Boolean prop126 = External.Has( (OperandVar125)); //IsContext = False IsNew = False
				OperandVar127 = prop126;
				if(ifResult123 = !(OperandVar127))
				{
					applicable = true;
					OperandVar128 = applicable;
				}
			}
			return (System.Boolean) (OperandVar128);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar129 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar129 != null) EntVar129.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar136 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable130 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable130 != null)
			{
				System.Boolean ifResult131; //IsContext = False IsNew = False
				System.Boolean OperandVar135 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar133 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable132 = ((Blackboards.personality)StoredVariable130.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable132 != null)
				{
					OperandVar133 = StoredVariable132;
				}
				System.Boolean prop134 = External.Has( (OperandVar133)); //IsContext = False IsNew = False
				OperandVar135 = prop134;
				if(ifResult131 = !(OperandVar135))
				{
					applicable = true;
					OperandVar136 = applicable;
				}
			}
			return (System.Boolean) (OperandVar136);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar137 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar137 != null) EntVar137.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar144 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable138 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable138 != null)
			{
				System.Boolean ifResult139; //IsContext = False IsNew = False
				System.Boolean OperandVar143 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar141 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable140 = ((Blackboards.aged_generation)StoredVariable138.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable140 != null)
				{
					OperandVar141 = StoredVariable140;
				}
				System.Boolean prop142 = External.Has( (OperandVar141)); //IsContext = False IsNew = False
				OperandVar143 = prop142;
				if(ifResult139 = !(OperandVar143))
				{
					applicable = true;
					OperandVar144 = applicable;
				}
			}
			return (System.Boolean) (OperandVar144);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar145 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar145 != null) EntVar145.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar155 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable146 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable146 != null)
			{
				Lore StoredVariable147 = ((Lore)StoredVariable146.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable147 != null)
				{
					Place StoredVariable148 = ((Place)StoredVariable147.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable148 != null)
					{
						System.Boolean ifResult149; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar151 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop150 = StoredVariable148.Agents; //IsContext = False IsNew = False
						if(prop150 != null)
						{
							OperandVar151 = prop150;
						}
						
						
						
						System.Boolean OperandVar154 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar152 = default(System.String); //IsContext = False IsNew = False
						OperandVar152 = "lore_pool";
						System.Boolean prop153 = StoredVariable146.HasMarker( (OperandVar152)); //IsContext = False IsNew = False
						OperandVar154 = prop153;
						if(ifResult149 = ( (( ( (OperandVar151 != null ? OperandVar151.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar154))))
						{
							applicable = true;
							OperandVar155 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar155);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext156 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext156 ContextSwitchInterpreter
				if(subContext156 != null)
				{
					
					subContext156.Size = (System.Int32)( (10f));
					System.Single OperandVar158 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop157 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar158 = prop157;
					for (int i = 0; i <  (OperandVar158); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag159 = old_ag; //IsContext = True IsNew = False
							Entity AddContext160 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext161 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext162 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext163 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext163 ContextSwitchInterpreter
								if(AddContext163 != null)
								{
									System.Single OperandVar165 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop164 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar165 = prop164;
									AddContext163.Age = (System.Int32)( (OperandVar165));
								}
							}
							Named AddContext166 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext166 ContextSwitchInterpreter
								if(AddContext166 != null)
								{
									
									
									
									AddContext166.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar169 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar167 = default(System.String); //IsContext = False IsNew = False
									OperandVar167 = "human_name";
									System.String prop168 = External.RandomName( (OperandVar167)); //IsContext = False IsNew = False
									if(prop168 != null)
									{
										OperandVar169 = prop168;
									}
									AddContext166.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar169)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar171 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable170 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable170 != null)
						{
							OperandVar171 = StoredVariable170;
						}
						subContext156.Attach((Agent)( (OperandVar171)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar181 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable172 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable172 != null)
			{
				Blackboards.historical_person StoredVariable173 = ((Blackboards.historical_person)StoredVariable172.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable173 != null)
				{
					Named StoredVariable174 = ((Named)StoredVariable173.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable174 != null)
					{
						Agent StoredVariable175 = ((Agent)StoredVariable174.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable175 != null)
						{
							System.Boolean ifResult176; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar178 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop177 = StoredVariable175.Act; //IsContext = False IsNew = False
							OperandVar178 = prop177;
							
							
							
							System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable172 != null)
							{
								System.Boolean prop179 = StoredVariable172.Dead; //IsContext = False IsNew = False
								OperandVar180 = prop179;
							}
							if(ifResult176 = ( (( ( (OperandVar178))) == ( ( (true))))) && ( (!(OperandVar180))))
							{
								applicable = true;
								OperandVar181 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar181);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext182 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext182 ContextSwitchInterpreter
				if(subContext182 != null)
				{
					
					System.String OperandVar185 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
					OperandVar183 = "human_name";
					System.String prop184 = External.RandomName( (OperandVar183)); //IsContext = False IsNew = False
					if(prop184 != null)
					{
						OperandVar185 = prop184;
					}
					subContext182.Switch(( ("main_name")).ToString(),( (OperandVar185)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar191 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable186 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable186 != null)
			{
				Named StoredVariable187 = ((Named)StoredVariable186.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable187 != null)
				{
					System.Boolean ifResult188; //IsContext = False IsNew = False
					
					System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable186 != null)
					{
						System.Boolean prop189 = StoredVariable186.Act; //IsContext = False IsNew = False
						OperandVar190 = prop189;
					}
					
					
					if(ifResult188 = ( ( (OperandVar190))) == ( ( (true))))
					{
						applicable = true;
						OperandVar191 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar191);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar195 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable192 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable192 != null)
			{
				System.String OperandVar193 = default(System.String); //IsContext = False IsNew = False
				OperandVar193 = "main_name";
				System.String prop194 = StoredVariable192.Get( (OperandVar193)); //IsContext = False IsNew = False
				if(prop194 != null)
				{
					OperandVar195 = prop194;
				}
			}
			External.Log((System.Object)( (OperandVar195)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar203 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable196 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable196 != null)
			{
				Agent StoredVariable197 = ((Agent)StoredVariable196.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable197 != null)
				{
					System.Boolean ifResult198; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar200 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop199 = StoredVariable197.Act; //IsContext = False IsNew = False
					OperandVar200 = prop199;
					
					
					
					System.Boolean OperandVar202 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable196 != null)
					{
						System.Boolean prop201 = StoredVariable196.Dead; //IsContext = False IsNew = False
						OperandVar202 = prop201;
					}
					if(ifResult198 = ( (( ( (OperandVar200))) == ( ( (true))))) && ( (!(OperandVar202))))
					{
						applicable = true;
						OperandVar203 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar203);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar204 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar204 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar204)))));
			UnityEngine.GameObject OperandVar205 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar205 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar205)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar214 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable206 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable206 != null)
			{
				System.Boolean ifResult207; //IsContext = False IsNew = False
				
				System.Boolean OperandVar210 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar208 = default(System.String); //IsContext = False IsNew = False
				OperandVar208 = "init_node";
				System.Boolean prop209 = StoredVariable206.HasMarker( (OperandVar208)); //IsContext = False IsNew = False
				OperandVar210 = prop209;
				
				System.Boolean OperandVar213 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar211 = default(System.String); //IsContext = False IsNew = False
				OperandVar211 = "story_set";
				System.Boolean prop212 = StoredVariable206.HasMarker( (OperandVar211)); //IsContext = False IsNew = False
				OperandVar213 = prop212;
				if(ifResult207 = ( ( (OperandVar210))) && ( (!(OperandVar213))))
				{
					applicable = true;
					OperandVar214 = applicable;
				}
			}
			return (System.Boolean) (OperandVar214);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext215 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext215 ContextSwitchInterpreter
				if(subContext215 != null)
				{
					System.String OperandVar216 = default(System.String); //IsContext = False IsNew = False
					OperandVar216 = "story_set";
					subContext215.SetMarker(( (OperandVar216)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node217 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext218 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext219 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext220 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext221 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext222 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext222 ContextPropertySwitchInterpreter
				if(subContext222 != null)
				{
					
					{
						TaleNode subContext223 = (TaleNode)subContext222.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext223 ContextSwitchInterpreter
						if(subContext223 != null)
						{
							
							subContext223.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar233 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable224 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable224 != null)
			{
				Blackboards.story_node StoredVariable225 = ((Blackboards.story_node)StoredVariable224.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable225 != null)
				{
					TaleNode StoredVariable226 = ((TaleNode)StoredVariable225.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable226 != null)
					{
						System.Boolean ifResult227; //IsContext = False IsNew = False
						
						System.Boolean OperandVar230 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar228 = default(System.String); //IsContext = False IsNew = False
						OperandVar228 = "decomposed";
						System.Boolean prop229 = StoredVariable224.HasMarker( (OperandVar228)); //IsContext = False IsNew = False
						OperandVar230 = prop229;
						
						System.Boolean OperandVar232 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop231 = StoredVariable226.IsActive; //IsContext = False IsNew = False
						OperandVar232 = prop231;
						if(ifResult227 = ( (!(OperandVar230))) && ( ( (OperandVar232))))
						{
							applicable = true;
							OperandVar233 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar233);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext234 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext234 ContextSwitchInterpreter
				if(subContext234 != null)
				{
					System.String OperandVar235 = default(System.String); //IsContext = False IsNew = False
					OperandVar235 = "decomposed";
					subContext234.SetMarker(( (OperandVar235)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node236 = c_node; //IsContext = True IsNew = False
				Markers AddContext237 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext238 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext239 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext240 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node241 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext242 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext243 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext244 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext245 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext245 ContextSwitchInterpreter
					if(AddContext245 != null)
					{
						UnityEngine.GameObject OperandVar246 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar246 = c_node;
						AddContext245.Conflict = (UnityEngine.GameObject)( (OperandVar246));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node247 = r_node; //IsContext = True IsNew = False
				Markers AddContext248 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext249 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext250 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext250 ContextSwitchInterpreter
					if(AddContext250 != null)
					{
						UnityEngine.GameObject OperandVar251 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar251 = c_r_node;
						AddContext250.Resolution = (UnityEngine.GameObject)( (OperandVar251));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node252 = s_node; //IsContext = True IsNew = False
				Markers AddContext253 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext254 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext255 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext256 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext256 ContextSwitchInterpreter
					if(AddContext256 != null)
					{
						UnityEngine.GameObject OperandVar257 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar257 = c_r_node;
						AddContext256.Cause = (UnityEngine.GameObject)( (OperandVar257));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node258 = cris_node; //IsContext = True IsNew = False
				Entity AddContext259 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext260 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext261 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext262 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext262 ContextSwitchInterpreter
					if(AddContext262 != null)
					{
						UnityEngine.GameObject OperandVar263 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar263 = s_node;
						AddContext262.Solution = (UnityEngine.GameObject)( (OperandVar263));
						UnityEngine.GameObject OperandVar264 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar264 = r_node;
						AddContext262.Cause = (UnityEngine.GameObject)( (OperandVar264));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext265 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext265 ContextPropertySwitchInterpreter
				if(subContext265 != null)
				{
					
					{
						TaleNode subContext266 = (TaleNode)subContext265.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext266 ContextSwitchInterpreter
						if(subContext266 != null)
						{
							
							subContext266.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext267 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext267 ContextPropertySwitchInterpreter
				if(subContext267 != null)
				{
					
					{
						TaleNode subContext268 = (TaleNode)subContext267.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext268 ContextSwitchInterpreter
						if(subContext268 != null)
						{
							
							subContext268.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext269 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext269 ContextPropertySwitchInterpreter
				if(subContext269 != null)
				{
					
					{
						TaleNode subContext270 = (TaleNode)subContext269.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext270 ContextSwitchInterpreter
						if(subContext270 != null)
						{
							
							subContext270.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext271 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext271 ContextPropertySwitchInterpreter
				if(subContext271 != null)
				{
					
					{
						TaleNode subContext272 = (TaleNode)subContext271.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext272 ContextSwitchInterpreter
						if(subContext272 != null)
						{
							
							subContext272.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext273 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext273 ContextPropertySwitchInterpreter
				if(subContext273 != null)
				{
					
					{
						TaleNode subContext274 = (TaleNode)subContext273.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext274 ContextSwitchInterpreter
						if(subContext274 != null)
						{
							
							subContext274.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar284 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable275 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable275 != null)
			{
				Blackboards.conflict_node StoredVariable276 = ((Blackboards.conflict_node)StoredVariable275.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable276 != null)
				{
					TaleNode StoredVariable277 = ((TaleNode)StoredVariable276.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable277 != null)
					{
						System.Boolean ifResult278; //IsContext = False IsNew = False
						
						System.Boolean OperandVar281 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar279 = default(System.String); //IsContext = False IsNew = False
						OperandVar279 = "decomposed";
						System.Boolean prop280 = StoredVariable275.HasMarker( (OperandVar279)); //IsContext = False IsNew = False
						OperandVar281 = prop280;
						
						System.Boolean OperandVar283 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop282 = StoredVariable277.IsActive; //IsContext = False IsNew = False
						OperandVar283 = prop282;
						if(ifResult278 = ( (!(OperandVar281))) && ( ( (OperandVar283))))
						{
							applicable = true;
							OperandVar284 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar284);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node285 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext286 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext287 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext288 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext288 ContextSwitchInterpreter
						if(AddContext288 != null)
						{
							UnityEngine.GameObject OperandVar289 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar289 = root;
							AddContext288.Conflict = (UnityEngine.GameObject)( (OperandVar289));
						}
					}
					Markers AddContext290 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext291 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext291 ContextPropertySwitchInterpreter
					if(subContext291 != null)
					{
						
						{
							TaleNode subContext292 = (TaleNode)subContext291.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext292 ContextSwitchInterpreter
							if(subContext292 != null)
							{
								
								subContext292.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext293 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext293 ContextSwitchInterpreter
				if(subContext293 != null)
				{
					System.String OperandVar294 = default(System.String); //IsContext = False IsNew = False
					OperandVar294 = "decomposed";
					subContext293.SetMarker(( (OperandVar294)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar301 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable295 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable295 != null)
			{
				TaleNode StoredVariable296 = ((TaleNode)StoredVariable295.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable296 != null)
				{
					System.Boolean ifResult297; //IsContext = False IsNew = False
					System.Boolean OperandVar300 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar298 = default(System.String); //IsContext = False IsNew = False
					OperandVar298 = "tale_enlisted";
					System.Boolean prop299 = StoredVariable295.HasMarker( (OperandVar298)); //IsContext = False IsNew = False
					OperandVar300 = prop299;
					if(ifResult297 = !(OperandVar300))
					{
						applicable = true;
						OperandVar301 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar301);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui302 = ui; //IsContext = True IsNew = False
				UiObject AddContext303 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext303 ContextSwitchInterpreter
					if(AddContext303 != null)
					{
						UnityEngine.GameObject OperandVar304 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar304 = root;
						AddContext303.ShowedObject = (UnityEngine.GameObject)( (OperandVar304));
					}
				}
				TextField AddContext305 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext305 ContextSwitchInterpreter
					if(AddContext305 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext306 = AddContext305.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext306 ContextPropertySwitchInterpreter
							if(subContext306 != null)
							{
								
								subContext306.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar309 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar307 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar307 = root;
						System.String prop308 = External.Stringify( (OperandVar307)); //IsContext = False IsNew = False
						if(prop308 != null)
						{
							OperandVar309 = prop308;
						}
						AddContext305.Show(( (OperandVar309)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar310 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar310 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar310)));
			
			{
				Markers subContext311 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext311 ContextSwitchInterpreter
				if(subContext311 != null)
				{
					System.String OperandVar312 = default(System.String); //IsContext = False IsNew = False
					OperandVar312 = "tale_enlisted";
					subContext311.SetUiMarker(( (OperandVar312)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar319 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable313 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable313 != null)
			{
				Markers StoredVariable314 = ((Markers)StoredVariable313.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable314 != null)
				{
					System.Boolean ifResult315; //IsContext = False IsNew = False
					System.Boolean OperandVar318 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar316 = default(System.String); //IsContext = False IsNew = False
					OperandVar316 = "faction_is_a_state";
					System.Boolean prop317 = StoredVariable314.HasMarker( (OperandVar316)); //IsContext = False IsNew = False
					OperandVar318 = prop317;
					if(ifResult315 = !(OperandVar318))
					{
						applicable = true;
						OperandVar319 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar319);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar320 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar320 != null) EntVar320.ComponentAdded();
			
			{
				Markers subContext321 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext321 ContextSwitchInterpreter
				if(subContext321 != null)
				{
					System.String OperandVar322 = default(System.String); //IsContext = False IsNew = False
					OperandVar322 = "faction_is_a_state";
					subContext321.SetMarker(( (OperandVar322)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar329 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable323 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable323 != null)
			{
				System.Boolean ifResult324; //IsContext = False IsNew = False
				System.Boolean OperandVar328 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar326 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable325 = ((Named)StoredVariable323.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable325 != null)
				{
					OperandVar326 = StoredVariable325;
				}
				System.Boolean prop327 = External.Has( (OperandVar326)); //IsContext = False IsNew = False
				OperandVar328 = prop327;
				if(ifResult324 = !(OperandVar328))
				{
					applicable = true;
					OperandVar329 = applicable;
				}
			}
			return (System.Boolean) (OperandVar329);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar330 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar330 ContextSwitchInterpreter
				if(ContextVar330 != null)
				{
					
					
					System.String OperandVar333 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar331 = default(System.String); //IsContext = False IsNew = False
					OperandVar331 = "country_name";
					System.String prop332 = External.RandomName( (OperandVar331)); //IsContext = False IsNew = False
					if(prop332 != null)
					{
						OperandVar333 = prop332;
					}
					ContextVar330.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar333)).ToString());
				}
			}
			Entity EntVar334 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar334 != null) EntVar334.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar344 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable335 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable335 != null)
			{
				TaleNode StoredVariable336 = ((TaleNode)StoredVariable335.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable336 != null)
				{
					System.Boolean ifResult337; //IsContext = False IsNew = False
					
					System.Boolean OperandVar341 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar339 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable335 != null)
					{
						UnityEngine.GameObject prop338 = StoredVariable335.Head; //IsContext = False IsNew = False
						if(prop338 != null)
						{
							OperandVar339 = prop338;
						}
					}
					System.Boolean prop340 = External.Has( (OperandVar339)); //IsContext = False IsNew = False
					OperandVar341 = prop340;
					
					System.Boolean OperandVar343 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop342 = StoredVariable336.IsActive; //IsContext = False IsNew = False
					OperandVar343 = prop342;
					if(ifResult337 = ( (!(OperandVar341))) && ( ( (OperandVar343))))
					{
						applicable = true;
						OperandVar344 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar344);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext345 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext345 ContextSwitchInterpreter
				if(subContext345 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state346 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext347 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext348 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext349 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext350 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext350 ContextSwitchInterpreter
							if(AddContext350 != null)
							{
								UnityEngine.GameObject OperandVar351 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar351 = root;
								AddContext350.State = (UnityEngine.GameObject)( (OperandVar351));
							}
						}
						Entity AddContext352 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext353 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext353 ContextPropertySwitchInterpreter
						if(subContext353 != null)
						{
							
							{
								TaleNode subContext354 = (TaleNode)subContext353.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext354 ContextSwitchInterpreter
								if(subContext354 != null)
								{
									
									subContext354.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar355 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar355 = head_of_state;
					subContext345.Head = (UnityEngine.GameObject)( (OperandVar355));
				}
			}
		}
        }
    }
    
    public class state_head_death : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar370 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable356 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable356 != null)
			{
				Markers StoredVariable357 = ((Markers)StoredVariable356.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable357 != null)
				{
					EntityDeathEvent StoredVariable358 = ((EntityDeathEvent)StoredVariable357.GetComponent(typeof(EntityDeathEvent))); //IsContext = False IsNew = False
					if(StoredVariable358 != null)
					{
						System.Boolean ifResult359; //IsContext = False IsNew = False
						
						System.Boolean OperandVar366 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable356 != null)
						{
							UnityEngine.GameObject prop360 = StoredVariable356.Context; //IsContext = False IsNew = False
							if(prop360 != null)
							{
								System.Boolean ifResult361; //IsContext = False IsNew = False
								System.Boolean OperandVar365 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.head_of_state_node OperandVar363 = default(Blackboards.head_of_state_node); //IsContext = False IsNew = False
								Blackboards.head_of_state_node StoredVariable362 = ((Blackboards.head_of_state_node)prop360.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
								if(StoredVariable362 != null)
								{
									OperandVar363 = StoredVariable362;
								}
								System.Boolean prop364 = External.Has( (OperandVar363)); //IsContext = False IsNew = False
								OperandVar365 = prop364;
								if(ifResult361 =  (OperandVar365))
								{
									OperandVar366 = ifResult361;
								}
							}
						}
						
						System.Boolean OperandVar369 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar367 = default(System.String); //IsContext = False IsNew = False
						OperandVar367 = "state_head_death_reacted";
						System.Boolean prop368 = StoredVariable357.HasMarker( (OperandVar367)); //IsContext = False IsNew = False
						OperandVar369 = prop368;
						if(ifResult359 = ( ( (OperandVar366))) && ( (!(OperandVar369))))
						{
							applicable = true;
							OperandVar370 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar370);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext371 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext371 ContextSwitchInterpreter
				if(subContext371 != null)
				{
					System.String OperandVar372 = default(System.String); //IsContext = False IsNew = False
					OperandVar372 = "state_head_death_reacted";
					subContext371.SetMarker(( (OperandVar372)).ToString());
				}
			}
			
			{
				Event subContext373 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext373 ContextSwitchInterpreter
				if(subContext373 != null)
				{
					
					{
						UnityEngine.GameObject subContext374 = subContext373.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext374 ContextPropertySwitchInterpreter
						if(subContext374 != null)
						{
							
							{
								Blackboards.head_of_state_node subContext375 = (Blackboards.head_of_state_node)subContext374.GetComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.head_of_state_node subContext375 ContextSwitchInterpreter
								if(subContext375 != null)
								{
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar382 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable376 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable376 != null)
			{
				System.Boolean ifResult377; //IsContext = False IsNew = False
				System.Boolean OperandVar381 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar379 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable378 = ((Named)StoredVariable376.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable378 != null)
				{
					OperandVar379 = StoredVariable378;
				}
				System.Boolean prop380 = External.Has( (OperandVar379)); //IsContext = False IsNew = False
				OperandVar381 = prop380;
				if(ifResult377 = !(OperandVar381))
				{
					applicable = true;
					OperandVar382 = applicable;
				}
			}
			return (System.Boolean) (OperandVar382);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar383 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar383 ContextSwitchInterpreter
				if(ContextVar383 != null)
				{
					System.String OperandVar384 = default(System.String); //IsContext = False IsNew = False
					OperandVar384 = "main_name";
					
					System.String OperandVar387 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar385 = default(System.String); //IsContext = False IsNew = False
					OperandVar385 = "human_name";
					System.String prop386 = External.RandomName( (OperandVar385)); //IsContext = False IsNew = False
					if(prop386 != null)
					{
						OperandVar387 = prop386;
					}
					ContextVar383.Set(( (OperandVar384)).ToString(),(System.Single)( (0f)),( (OperandVar387)).ToString());
				}
			}
			Entity EntVar388 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar388 != null) EntVar388.ComponentAdded();
		}
        }
    }
    
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar398 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable389 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable389 != null)
			{
				Markers StoredVariable390 = ((Markers)StoredVariable389.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable390 != null)
				{
					System.Boolean ifResult391; //IsContext = False IsNew = False
					
					System.Boolean OperandVar394 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar392 = default(System.String); //IsContext = False IsNew = False
					OperandVar392 = "map_anchored";
					System.Boolean prop393 = StoredVariable390.HasMarker( (OperandVar392)); //IsContext = False IsNew = False
					OperandVar394 = prop393;
					
					System.Boolean OperandVar397 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar395 = default(System.String); //IsContext = False IsNew = False
					OperandVar395 = "history_place";
					System.Boolean prop396 = StoredVariable390.HasMarker( (OperandVar395)); //IsContext = False IsNew = False
					OperandVar397 = prop396;
					if(ifResult391 = ( (!(OperandVar394))) && ( ( (OperandVar397))))
					{
						applicable = true;
						OperandVar398 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar398);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext399 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext399 ContextSwitchInterpreter
				if(subContext399 != null)
				{
					System.String OperandVar400 = default(System.String); //IsContext = False IsNew = False
					OperandVar400 = "map_anchored";
					subContext399.SetUiMarker(( (OperandVar400)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar401 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar401 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar401)));
		}
        }
    }
}
